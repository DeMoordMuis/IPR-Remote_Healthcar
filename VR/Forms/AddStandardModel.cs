﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VR {
    partial class AddStandardModel : Form {
        private Connector connector;

        public AddStandardModel(Connector connector) {
            InitializeComponent();
            this.connector = connector;

            model_Box.Items.Add("Tree");
            model_Box.Items.Add("Car");
            model_Box.Items.Add("House");
        }

        private void Add_Model_Btn_Click(object sender, EventArgs e) {
            string path = Directory.GetCurrentDirectory();
            path = path.Substring(0, path.Length - 9);
            path += @"Objects\";
            Console.WriteLine(path);

            if (model_Box.SelectedItem != null) {
                if (Position_X_Txt.Text.Length > 0 && Position_Y_Txt.Text.Length > 0 && Position_Z_Txt.Text.Length > 0) {
                    if (model_Box.SelectedItem.Equals("Tree"))
                        connector.AddModel("Tree", path + "tree1.pbj", int.Parse(Position_X_Txt.Text), int.Parse(Position_Y_Txt.Text), int.Parse(Position_Z_Txt.Text));
                    else if (model_Box.SelectedItem.Equals("Car"))
                        connector.AddModel("Tree", path + "car_white.pbj", int.Parse(Position_X_Txt.Text), int.Parse(Position_Y_Txt.Text), int.Parse(Position_Z_Txt.Text));
                    else if (model_Box.SelectedItem.Equals("House"))
                        connector.AddModel("Tree", path + "house1.pbj", int.Parse(Position_X_Txt.Text), int.Parse(Position_Y_Txt.Text), int.Parse(Position_Z_Txt.Text));
                    this.Hide();
                }
                else
                    MessageBox.Show("Vul de coördinaten in");
            }
            else
                MessageBox.Show("Kies een model");
        }
    }
}
