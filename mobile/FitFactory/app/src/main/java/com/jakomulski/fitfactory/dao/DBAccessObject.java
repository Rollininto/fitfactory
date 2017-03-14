package com.jakomulski.fitfactory.dao;


import android.os.StrictMode;
import android.util.Log;

import com.jakomulski.fitfactory.models.Comment;
import com.jakomulski.fitfactory.models.Exercise;
import com.jakomulski.fitfactory.models.Goal;
import com.jakomulski.fitfactory.models.Programme;
import com.jakomulski.fitfactory.models.Specialization;
import com.jakomulski.fitfactory.models.Trainer;
import com.jakomulski.fitfactory.models.Training;
import com.jakomulski.fitfactory.models.User;


import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.io.UnsupportedEncodingException;
import java.net.HttpURLConnection;
import java.net.URL;
import java.security.MessageDigest;
import java.security.NoSuchAlgorithmException;
import java.sql.*;
import java.util.ArrayList;
import java.util.List;


public class DBAccessObject extends DAO {
    private static DBAccessObject instance;

    private static final String USER = "fitfactoryadmin";
    private static final String PASSWORD = "&(@#(*$yh383";
    private static final String SERVER = "fitfactory.database.windows.net:1433";
    private static final String DATABASE = "fitfactory_database";

    private static final Character USER_TYPE = 'U';
    private Connection connection = null;

    private int userId;
    private String login;
    private int programmeId;
    private int trainerId;
    private int trainingId;

    public String getLogin(){
        return this.login;
    }

    public int getUserId(){
        return userId;
    }

    DBAccessObject() throws SQLException {
        StrictMode.ThreadPolicy policy = new StrictMode.ThreadPolicy.Builder()
                .permitAll().build();
        StrictMode.setThreadPolicy(policy);

        String ConnectionURL = null;
        try {
            //new net.sourceforge.jtds.jdbc.Driver();
            Class.forName("net.sourceforge.jtds.jdbc.Driver");
            ConnectionURL = "jdbc:jtds:sqlserver://" + SERVER + ";"
                    + "databaseName=" + DATABASE + ";user=" + USER
                    + ";password=" + PASSWORD + ";";
            connection = DriverManager.getConnection(ConnectionURL);
        } catch (ClassNotFoundException se) {
            Log.e("ERRO", se.getMessage());
        }
    }

    public static DBAccessObject getInstance() throws SQLException {
        if(instance == null)
            instance = new DBAccessObject();
        return instance;
    }

    private String getHash(String value) {
        String hash = "";
        try {
            byte[] bytesOfMessage = value.getBytes("UTF-8");
            MessageDigest md5 = java.security.MessageDigest.getInstance("MD5");
            byte[] byteHash = md5.digest(bytesOfMessage);

            StringBuffer sb = new StringBuffer();
            for (int i = 0; i < byteHash.length; i++) {
                sb.append(Integer.toString((byteHash[i] & 0xff) + 0x100, 16).substring(1));
            }
            hash = sb.toString();
        } catch (NoSuchAlgorithmException e) {
            e.printStackTrace();
        } catch (UnsupportedEncodingException e) {
            e.printStackTrace();
        }
        return hash;
    }

    public void addUser(User user) {
        String addUserSql = "{call wstawUzytkownika2(?,?,?,?,?,?,?,?,?)}";

        try {
            CallableStatement cStmt = connection.prepareCall(addUserSql);
            cStmt.setString(1, user.login);
            cStmt.setString(2, user.email);
            cStmt.setString(3, user.name);
            cStmt.setString(4, user.secondName);
            cStmt.setString(5, user.lastName);
            cStmt.setString(6, user.sex.toString());
            cStmt.setString(7, "13/11/2016");
            cStmt.setString(8, getHash(user.password+user.login));
            cStmt.setString(9, "U");

            //cStmt.execute();
            //ResultSet rs = cStmt.getResultSet();
            //cStmt.getString(1);
            ResultSet rs  = cStmt.executeQuery();
            if(rs != null) {
                rs.next();
                String token = rs.getString(1);
                this.userId = rs.getInt(2);
                //if(!token.equals("03"))
                sendMail(user.email, token, user.name );
            }
            if(rs == null) {
//                String hash = getHash(user.login+user.lastName).toUpperCase();
//
//                sendMail(user.email, hash, user.name );
            }


        } catch (SQLException e) {
            e.printStackTrace();
        }

    }

    public boolean isCorrectLoginAndPassword(String login, String password) {
        String userExistsSql = "{call czyLoginHasloIstnieje(?,?,?)}";
        Boolean isCorrectLoginAndPassword = false;

        try {
            CallableStatement cStmt = connection.prepareCall(userExistsSql);
            cStmt.setString(1, login);
            cStmt.setString(2, getHash(password+login));
            cStmt.setString(3, "U");

            cStmt.execute();

            ResultSet rs = cStmt.getResultSet();

            rs.next();

            isCorrectLoginAndPassword = rs.getBoolean(1);
            this.userId = rs.getInt(1);
        } catch (SQLException e) {
            e.printStackTrace();
        }
        if(isCorrectLoginAndPassword) {
            this.login = login;

        }
        return isCorrectLoginAndPassword;
    }

    public List<Specialization> getSpecializations() {
        String getSpecializations = "{call wypiszSpecjalizacje()}";

        List<Specialization> specializations = new ArrayList<Specialization>();

        try {
            CallableStatement cStmt = connection.prepareCall(getSpecializations);
            cStmt.execute();

            ResultSet rs = cStmt.getResultSet();
            while(rs.next()) {
                Specialization specialization = new Specialization(rs.getInt(1), rs.getString(2), rs.getString(3));
                specializations.add(specialization);
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }
        return specializations;
    }

    public List<Trainer> getTrainers(int specializationId) {
        String getTrainersSql = "{call wypiszListeTrenerow(?)}";

        List<Trainer> trainers = new ArrayList<Trainer>();

        try {
            CallableStatement cStmt = connection.prepareCall(getTrainersSql);
            cStmt.setInt(1, specializationId);


            cStmt.execute();

            ResultSet rs = cStmt.executeQuery();
            while(rs.next()) {
                Trainer trainer = new Trainer(rs.getInt(1), rs.getString(2), rs.getString(3), rs.getString(4), rs.getString(5));
                trainers.add(trainer);
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }
        return trainers;
    }

    public void addComment(String text, int addresseeId) {
        String addCommentSql = "{call wyslijWiadomosc(?,?,?)}";
        try {
            CallableStatement cStmt = connection.prepareCall(addCommentSql);
            cStmt.setInt(1, this.userId);
            cStmt.setInt(2, this.trainerId);
            cStmt.setString(3, text);

            cStmt.execute();

            ResultSet rs = cStmt.getResultSet();

            //rs.next();
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

    public void doExercise(int num) {
        String addCommentSql = "{call odrobCwiczenie(?,?)}";
        try {
            CallableStatement cStmt = connection.prepareCall(addCommentSql);
            cStmt.setInt(1, this.trainingId);
            cStmt.setInt(2, num);


            cStmt.execute();

            ResultSet rs = cStmt.getResultSet();

            //rs.next();
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

    public void setProgrammeId(int programmeId) {
        this.programmeId = programmeId;
    }

    public void setTrainingId(int trainingId) {
        this.trainingId = trainingId;
    }

    @Override
    public void setTrainerId(int trainerId) {
        this.trainerId = trainerId;
    }

    public void addTrainigDay(String date) {
        String addCommentSql = "{call dodajDniTreningow(?,?)}";
        try {
            CallableStatement cStmt = connection.prepareCall(addCommentSql);
            cStmt.setInt(1, this.programmeId);
            cStmt.setString(2, date);

            cStmt.execute();

            ResultSet rs = cStmt.getResultSet();

            //rs.next();
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

    public List<Comment> getComments(int addresseeId) {
        String getCommentsSql = "{call wypiszWiadomosci(?,?)}";

        List<Comment> comments = new ArrayList<Comment>();

        try {
            CallableStatement cStmt = connection.prepareCall(getCommentsSql);
            cStmt.setInt(1, this.userId);
            cStmt.setInt(2, this.trainerId);

            cStmt.execute();


            ResultSet rs = cStmt.getResultSet();
            while (rs.next()) {
                Comment comment = new Comment(rs.getString(1), rs.getBoolean(2), rs.getInt(3), rs.getInt(4));
                comments.add(comment);
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }
        return comments;
    }

    public List<Trainer> getTrainers() {
        String getTrainersSql = "{call wypiszListeTrenerowUzytkownika(?)}";

        List<Trainer> trainers = new ArrayList<Trainer>();

        try {
            CallableStatement cStmt = connection.prepareCall(getTrainersSql);
            cStmt.setInt(1, this.userId);



            ResultSet rs = cStmt.executeQuery();
            while(rs.next()) {
                Trainer trainer = new Trainer(rs.getInt(1), rs.getString(2), rs.getString(3), null, null);
                trainers.add(trainer);
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }
        return trainers;
    }

    public List<Programme> getProgrammes(int trainerId) {
        String getCommentsSql = "{call wypiszProgramyUz(?,?)}";

        List<Programme> programmes = new ArrayList<Programme>();

        try {
            CallableStatement cStmt = connection.prepareCall(getCommentsSql);
            cStmt.setInt(1, this.userId);
            cStmt.setInt(2, -1);

            ResultSet rs = cStmt.executeQuery();

            while (rs.next()) {
                Programme programme = new Programme(rs.getInt(2), rs.getString(10),  rs.getString(9), null, null);
                programmes.add(programme);
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }
        return programmes;
    }


    public List<Training> getTrainings(int progremmeId) {
        String getCommentsSql = "{call pobierzTreningi(?)}";

        List<Training> trainings = new ArrayList<Training>();

        try {
            CallableStatement cStmt = connection.prepareCall(getCommentsSql);
            cStmt.setInt(1, this.programmeId);


            ResultSet rs = cStmt.executeQuery();

            while (rs.next()) {
                Training training = new Training(rs.getInt(1), rs.getDate(2), rs.getBoolean(3));
                trainings.add(training);
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }
        return trainings;
    }

    public List<Exercise> getExercises() {
        String sql = "{call wypiszCwiczeniaTreningu(?)}";

        List<Exercise> exercises = new ArrayList<Exercise>();

        try {
            CallableStatement cStmt = connection.prepareCall(sql);
            cStmt.setInt(1, this.trainingId);


            ResultSet rs = cStmt.executeQuery();

            while (rs.next()) {
                Exercise exercise = new Exercise(rs.getInt(1), rs.getString(2),rs.getInt(3),rs.getBoolean(4), rs.getString(5));
                exercises.add(exercise);
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }
        return exercises;
    }

    public String sentInvitation(int userId, int trainerId) {
        String sentInvitationSQL = "{call zaprosTrenera(?,?,?,?)}";

        try {
            CallableStatement cStmt = connection.prepareCall(sentInvitationSQL);
            cStmt.setInt(1, this.userId);
            cStmt.setInt(2, trainerId);
            cStmt.setInt(3, 1);
            cStmt.setString(4, "desc");

            cStmt.execute();

            ResultSet rs = cStmt.getResultSet();
            //rs.next();

        } catch (SQLException e) {
            e.printStackTrace();
            if(e.getErrorCode() == 2627)
                return "wysłano zaproszenie";
        }
        return "";
    }

    @Override
    public List<Trainer> getAvaiableTrainers(int userId) {
        return new ArrayList<Trainer>();
    }

    @Override
    public List<Goal> getGoals() {
        String getGoalsSql = "{call wypiszCele()}";

        List<Goal> goals = new ArrayList<Goal>();

        try {
            CallableStatement cStmt = connection.prepareCall(getGoalsSql);


            cStmt.execute();

            ResultSet rs = cStmt.getResultSet();
            while(rs.next()) {
                Goal goal = new Goal(rs.getInt(1), rs.getString(2), rs.getString(3));
                goals.add(goal);
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }
        return goals;
    }

    public User correctLoginAndPassword(String login, String password) {
        Statement stmt = null;
        User user = new User();
        try {
            stmt = connection.createStatement();

            String query = String.format("SELECT * FROM UZYTKOWNICY WHERE login = '%s' AND haslo = '%s'", login, password);
            ResultSet reset = stmt.executeQuery(query);


            reset.next();

            user.login = reset.getString("login");
            user.email = reset.getString("mail");
            user.name = reset.getString("imie");
            user.lastName = reset.getString("nazwisko");
            user.sex = reset.getString("plec").charAt(0);
            user.birthDate = reset.getDate("data_ur");



        } catch (SQLException e) {
            Log.e("ERRO", e.getMessage());
        }
        return user;
    }

    private void sendMail(String email, String token, String name) {

        String url = String.format("http://fitfactory.azurewebsites.net/sendmail.php?email=%s&token=%s&name=%s",email, token, name);

        final String USER_AGENT = "Mozilla/5.0";
        URL obj = null;
        try {
            obj = new URL(url);
            HttpURLConnection con = (HttpURLConnection) obj.openConnection();

            // optional default is GET
            con.setRequestMethod("GET");

            //add request header
            con.setRequestProperty("User-Agent", USER_AGENT);

            int responseCode = con.getResponseCode();
            System.out.println("\nSending 'GET' request to URL : " + url);
            System.out.println("Response Code : " + responseCode);

            BufferedReader in = new BufferedReader(
                    new InputStreamReader(con.getInputStream()));
            String inputLine;
            StringBuffer response = new StringBuffer();

            while ((inputLine = in.readLine()) != null) {
                response.append(inputLine);
            }
            in.close();

            //print result
            //System.out.println(response.toString());
        } catch (Exception e) {
            e.printStackTrace();
        }


    }

}
