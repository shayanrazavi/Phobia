using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Drawing;

public class moama : MonoBehaviour
{
    public List<int> keys = new List<int> (){1,0,0,1,0};

    // Start is called before the first frame update
    public void Start()
    {

    }

    // Update is called once per frame
    public void Update()
    {
        public void button1_Click(object sender, FileName){
            openFileDialog1.Filter = “Jpg image(*.jpg)|*.jpg|” + “Bmp image(*.bmp)|*.bmp|” + “Png  image(*.png)|*.png|” + “All Files(*.*)|*.*”;

            if (openFileDialog1.ShowDialog() == DialogResult.OK){
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        if (Input.GetKeyDown(KeyCode.0)){
            if (keys[0] == 0){
                keys[0] = 1;
            }else{
                keys[0] = 0;
            }
        }else if (Input.GetKeyDown(KeyCode.1)){
            if (keys[0] == 0){
                keys[0] = 1;
            }else{
                keys[0] = 0;
            }
        }else if (Input.GetKeyDown(KeyCode.2)){
            if (keys[2] == 0){
                keys[2] = 1;
            }else{
                keys[2] = 0;
            }
        }else if (Input.GetKeyDown(KeyCode.3)){
            if (keys[3] == 0){
                keys[3] = 1;
            }else{
                keys[3] = 0;
            }
        }else if (Input.GetKeyDown(KeyCode.4)){
            if (keys[4] == 0){
                keys[4] = 1;
            }else{
                keys[4] = 0;
            }
        }

        if (keys != {0,1,1,1,0}){
                if (keys == {0,0,0,0,0}){
                button1_Click(FileName0);
            }else if (keys == {0,0,0,0,1}){
                button1_Click(FileName1);
            }else if (keys == {0,0,0,1,0}){
                button1_Click(FileName2);
            }else if (keys == {0,0,0,1,1}){
                button1_Click(FileName3);
            }else if (keys == {0,0,1,0,0}){
                button1_Click(FileName4);
            }else if (keys == {0,0,1,0,1}){
                button1_Click(FileName5);
            }else if (keys == {0,0,1,1,0}){
                button1_Click(FileName6);
            }else if (keys == {0,0,1,1,1}){
                button1_Click(FileName7);
            }else if (keys == {0,1,0,0,0}){
                button1_Click(FileName8);
            }else if (keys == {0,1,0,0,1}){
                button1_Click(FileName9);
            }else if (keys == {0,1,0,1,0}){
                button1_Click(FileName10);
            }else if (keys == {0,1,0,1,1}){
                button1_Click(FileName11);
            }else if (keys == {0,1,1,0,0}){
                button1_Click(FileName12);
            }else if (keys == {0,1,1,0,1}){
                button1_Click(FileName13);
            }else if (keys == {0,1,1,1,0}){
                button1_Click(FileName14);
            }else if (keys == {0,1,1,1,1}){
                button1_Click(FileName15);
            }else if (keys == {1,0,0,0,0}){
                button1_Click(FileName16);
            }else if (keys == {1,0,0,0,1}){
                button1_Click(FileName17);
            }else if (keys == {1,0,0,1,0}){
                button1_Click(FileName18);
            }else if (keys == {1,0,0,1,1}){
                button1_Click(FileName19);
            }else if (keys == {1,0,1,0,0}){
                button1_Click(FileName20);
            }else if (keys == {1,0,1,0,1}){
                button1_Click(FileName21);
            }else if (keys == {1,0,1,1,0}){
                button1_Click(FileName22);
            }else if (keys == {1,0,1,1,1}){
                button1_Click(FileName23);
            }else if (keys == {1,1,0,0,0}){
                button1_Click(FileName24);
            }else if (keys == {1,1,0,0,1}){
                button1_Click(FileName25);
            }else if (keys == {1,1,0,1,0}){
                button1_Click(FileName26);
            }else if (keys == {1,1,0,1,1}){
                button1_Click(FileName27);
            }else if (keys == {1,1,1,0,0}){
                button1_Click(FileName28);
            }else if (keys == {1,1,1,0,1}){
                button1_Click(FileName29);
            }else if (keys == {1,1,1,1,0}){
                button1_Click(FileName30);
            }else if (keys == {1,1,1,1,1}){
                button1_Click(FileName31);
            }
        }
    }
}
