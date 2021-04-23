/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author hp 15
 */
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import javax.swing.JOptionPane;

public class Conexion {
    private String sSQL = "";
    private String usuario = "Lizzi";
    private String pass = "inuyasha7";
    private String host = "localhost";
    private String nombre_BD = "bd java";

    private Connection con = null;
    
    public Conexion() {
    }
    //Metodo que se devuelve la conexion o null si hubo un error
    public String getConexion(){
        try{
            Class.forName("com.mysql.jdbc.Driver").newInstance( );
            String servidor = "jdbc:mysql://"+host+"/"+nombre_BD;
            con = DriverManager.getConnection(servidor,usuario,pass);
            return "conectado: "+con;
        }catch(Exception e){
            e.printStackTrace();
            return "Fallo: "+con;
        }
    } 
    
    public boolean insertar(String nombres, String apellidos, String time) {
        sSQL = "insert into registro (nombres,apellidos,fechaHora)"
                + "values (?,?,?)";
       
        try {
            PreparedStatement pst = con.prepareStatement(sSQL);
            
            pst.setString(1, nombres);
            pst.setString(2, apellidos);
            pst.setString(3, time);
           
            int n = pst.executeUpdate();

            if (n != 0) {
                return true;
            } else {
                return false;
            }

        } catch (Exception e) {
            JOptionPane.showConfirmDialog(null, e);
            return false;
        }
    }
    
}
