﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winfrom5
{
    public partial class Winform5_2 : Form
    {
        private Point PreviousPoint, point; //Точка до перемещения курсора мыши и текущая точка
        private Bitmap bmp;
        private Pen blackPen;
        private Graphics g;
        public Winform5_2()
        {
            InitializeComponent();
        }

        private void Winform5_2_Load(object sender, EventArgs e)
        {
            blackPen = new Pen(Color.Black, 4); //подготавливаем перо для рисования
        }

        private void loadFileBtn_Click(object sender, EventArgs e)
        {   //открытие файла
            OpenFileDialog dialog = new OpenFileDialog(); //описываем и порождаем объект dialog класса OpenFileDialog
            //задаем расширения файлов 
            dialog.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)|*.bmp;*.jpg;*.gif; *.tif; *.png; *.ico; *.emf; *.wmf";
            if (dialog.ShowDialog() == DialogResult.OK)//вызываем диалоговое окно и проверяем выбран ли файл
            {
                Image image = Image.FromFile(dialog.FileName); //Загружаем в image изображение из выбранного файла
                int width = image.Width;
                int height = image.Height;
                pictureBox1.Width = width;
                pictureBox1.Height = height;

                bmp = new Bitmap(image, width, height); //создаем и загружаем из image изображение в форматье bmp

                pictureBox1.Image = bmp; //записываем изображение в формате bmp в pictureBox1
                g = Graphics.FromImage(pictureBox1.Image); //подготавливаем объект Graphics для рисования в pictureBox1

            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        { // обработчик события нажатия кнопки на мыши
            // записываем в предыдущую точку (PreviousPoint) текущие координаты
            PreviousPoint.X = e.X;
            PreviousPoint.Y = e.Y;
        }


        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {//Обработчик события перемещения мыши по pictuteBox1
            if (e.Button == MouseButtons.Left) //Проверяем нажата ли левая кнопка мыши
            {   //запоминаем в point текущее положение курсора мыши
                point.X = e.X;
                point.Y = e.Y;

                //соеденяем линией предыдущую точку с текущей
                g.DrawLine(blackPen, PreviousPoint, point);

                //текущее положение курсора мыши сохраняем в PreviousPoint
                PreviousPoint.X = point.X;
                PreviousPoint.Y = point.Y;
                pictureBox1.Invalidate();//Принудительно вызываем переррисовку pictureBox1
            }
        }


        private void saveFileBtn_Click(object sender, EventArgs e)
        { //сохранение файла
            SaveFileDialog savedialog = new SaveFileDialog();//описываем и порождаем объект savedialog 
            //задаем свойства для savedialog
            savedialog.Title = "Сохранить картинку как ...";
            savedialog.OverwritePrompt = true;
            savedialog.CheckPathExists = true;
            savedialog.Filter =
                "Bitmap File(*.bmp)|*.bmp|" +
                "GIF File(*.gif)|*.gif|" +
                "JPEG File(*.jpg)|*.jpg|" +
                "TIF File(*.tif)|*.tif|" +
                "PNG File(*.png)|*.png";
            savedialog.ShowHelp = true;
            // If selected, save
            if (savedialog.ShowDialog() == DialogResult.OK)//вызываем диалоговое окно и проверяем задано ли имя файла
            {
                // в строку fileName записываем указанный в savedialog полный путь к файлу
                string fileName = savedialog.FileName;
                // Убираем из имени три последних символа (расширение файла)
                string strFilExtn =
                    fileName.Remove(0, fileName.Length - 3);
                // Сохраняем файл в нужном формате и с нужным расширением
                switch (strFilExtn)
                {
                    case "bmp":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    case "jpg":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case "gif":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                    case "tif":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Tiff);
                        break;
                    case "png":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                    default:
                        break;
                }
            }
        }
        private void RecolorPicture(string color)
        {
            //циклы для перебора всех пикселей на изображении
            for (int i = 0; i < bmp.Width; i++)
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color pixel = bmp.GetPixel(i, j);
                    int R = pixel.R; //извлекаем в R значение красного цвета в текущей точке
                    int G = pixel.G; //извлекаем в G значение зеленого цвета в текущей точке
                    int B = pixel.B; //извлекаем в B значение синего цвета в текущей точке
                    int test = (R + G + B);
                    if (test >= 255)
                    {
                        test /= 3;
                    }
                    Color p;
                    if (color == "R")
                    {
                        p = Color.FromArgb(255, test, 0, 0); //переводим int в значение цвета. 255 - показывает степень прозрачности. остальные значения одинаковы для трех каналов R,G,B
                    }
                    else if (color == "G")
                    {
                        p = Color.FromArgb(255, 0, test, 0); //переводим int в значение цвета. 255 - показывает степень прозрачности. остальные значения одинаковы для трех каналов R,G,B
                    }
                    else
                    {
                        p = Color.FromArgb(255, 0, 0, test); //переводим int в значение цвета. 255 - показывает степень прозрачности. остальные значения одинаковы для трех каналов R,G,B
                    }
                    bmp.SetPixel(i, j, p); //записываме полученный цвет в текущую точку
                }
            Refresh(); //вызываем функцию перерисовки окна
        }


        private void onlyR_Click(object sender, EventArgs e)
        {
            RecolorPicture("R");
        }


        private void onlyG_Click(object sender, EventArgs e)
        {
            RecolorPicture("G");
        }

        private void onlyB_Click(object sender, EventArgs e)
        {
            RecolorPicture("B");
        }
    }
}
