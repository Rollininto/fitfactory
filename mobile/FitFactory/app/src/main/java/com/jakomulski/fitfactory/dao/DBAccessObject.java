package com.jakomulski.fitfactory.dao;


import android.os.StrictMode;
import android.util.Log;
import com.jakomulski.fitfactory.models.Goal;
import com.jakomulski.fitfactory.models.Specialization;
import com.jakomulski.fitfactory.models.Trainer;
import com.jakomulski.fitfactory.models.User;


import java.io.UnsupportedEncodingException;
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



        String addUserSql = "{call wstawUzytkownika(?,?,?,?,?,?,?,?,?)}";

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

            cStmt.execute();
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
        } catch (SQLException e) {
            e.printStackTrace();
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

            ResultSet rs = cStmt.getResultSet();
            rs.next();
            Trainer trainer = new Trainer(rs.getInt(1), rs.getString(2),rs.getString(3), rs.getString(4), rs.getString(5));
            trainers.add(trainer);
        } catch (SQLException e) {
            e.printStackTrace();
        }
        return trainers;
    }

    public void sentInvitation(int userId, int trainerId) {
        String sentInvitationSQL = "{call zaprosTrenera(?,?,?,?)}";



        try {
            CallableStatement cStmt = connection.prepareCall(sentInvitationSQL);
            cStmt.setInt(1, userId);
            cStmt.setInt(2, trainerId);
            cStmt.setInt(3, 1);
            cStmt.setString(4, "desc");

            cStmt.execute();

            ResultSet rs = cStmt.getResultSet();

        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

    @Override
    public List<Trainer> getAvaiableTrainers(int userId) {
        return new ArrayList<Trainer>();
    }

    @Override
    public List<Goal> getGoals() {
        List<Goal> goals = new ArrayList<>();
        goals.add(new Goal(1,"utrata wagi"));
        goals.add(new Goal(2,"siła"));
        goals.add(new Goal(3,"wytrzymałość"));
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

}
