/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package logica_validacion;

import javax.swing.JLabel;
import javax.swing.JTextField;

/**
 *
 * @author JoséDanielBarrazaLin
 */
public class logicaValidacion {
    public static void validacion(String tipoValidar, JLabel Label,JTextField TextField){
            if (tipoValidar == "cp") {
                if (TextField.getText().length()!=5) {
                    Label.setText("Error, no tiene 5 digitos");
                }
            } else if(tipoValidar == "dni") {
                if (TextField.getText().length()!=9)
                {
                    Label.setText("Error, no tiene 9 digitos");
                }
            }
            else if (tipoValidar == "correo"){
                if (!TextField.getText().contains("@"))
                {
                    Label.setText("Error, no tiene @");
                }
            }
        }
}
