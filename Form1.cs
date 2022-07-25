using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Activity_5_W2
{
    

    public partial class Form1 : Form
    {
        StreamReader inputFile;

        public Form1()
        {
            InitializeComponent();
        }

        private void ProcessBut_Click(object sender, EventArgs e)
        {
            String initialPhrase;
            openFile.InitialDirectory = "C:\\Users\\esm72\\OneDrive\\Desktop\\CST-150\\Week 3";
            openFile.ShowDialog();
            inputFile = File.OpenText(openFile.FileName);
            initialPhrase = inputFile.ReadToEnd();
            MessageBox.Show("The file's content is: \n" + initialPhrase);

            //Here we are calling on the methods to handle these tasks.
            lowerCase(initialPhrase);
            longestWord();
            sortAlpha();
            mostVowels();


        }

        //Method for making content all lowercase:
        private void lowerCase(String initialPhrase)
        {
            String lowerCasePhrase = initialPhrase.ToLower();
            MessageBox.Show("Content all Lowercase:\n" + lowerCasePhrase);
        


        }

        //Method for finding longest word
        private void longestWord()
        {
            inputFile = File.OpenText(openFile.FileName);

            String longestWord = "";
            String prevWord = " ";
            String currentWord;
            while (!inputFile.EndOfStream)
            {
                currentWord = inputFile.ReadLine();
                if(currentWord.Length > prevWord.Length) //We used prevWord on multiple occasions to remember the last word we are comparing to.
                {
                    longestWord = currentWord;
                    prevWord = currentWord;
                }
            }
            MessageBox.Show("The longest word is:\n" + longestWord);
        }


        private void sortAlpha()
        {
            inputFile = File.OpenText(openFile.FileName);


            String firstWord = "Z";
            String lastWord = " ";
            String currentWord;
            String prevWord = "a"; 
            
            


            while (!inputFile.EndOfStream)
            {
                currentWord = inputFile.ReadLine();


                if (String.Compare(currentWord, prevWord) < 0) 
                {
                    if(String.Compare(currentWord, firstWord) < 0)
                    {
                        firstWord= currentWord;
                    }
                }
                if (String.Compare(currentWord, prevWord) > 0)
                {
                  
                    if (String.Compare(currentWord, lastWord) > 0)
                    {
                        lastWord = currentWord;
                    }
                }
                prevWord = currentWord;


            }

            MessageBox.Show("The first and last word sorted alphabetically is:\n"+
                "First: " + firstWord + "\nLast: " + lastWord);
        }

        private void mostVowels()
        {
            inputFile = File.OpenText(openFile.FileName);
            String currentWord;
            String mostVowWord = " ";
            int vowelTotal = 0;
            int prevWordTotal = 0;


            while (!inputFile.EndOfStream)
                
            {
                vowelTotal = 0;
                currentWord = inputFile.ReadLine();
                //Below we unrolled the for loop that would have ran the length of each word for debugging purposes only. it would have also used the OR operator to look for all vowels.
                //comparing lowercase
                if (currentWord.Contains("a"))
                {
                    vowelTotal++;
                }
                if (currentWord.Contains("e")) { 
                    vowelTotal++;
                 }
                if (currentWord.Contains("i"))
                {
                    vowelTotal++;
                }
                if (currentWord.Contains("o"))
                {
                    vowelTotal++;
                }
                if (currentWord.Contains("u"))
                {
                    vowelTotal++;
                }
                //Comparing uppercase
                if (currentWord.Contains("A"))
                {
                    vowelTotal++;
                }
                if (currentWord.Contains("E"))
                {
                    vowelTotal++;
                }
                if (currentWord.Contains("I"))
                {
                    vowelTotal++;
                }
                if (currentWord.Contains("O"))
                {
                    vowelTotal++;
                }
                if (currentWord.Contains("U"))
                {
                    vowelTotal++;
                }
                if(vowelTotal > prevWordTotal)
                {
                    mostVowWord = currentWord;
                }
                prevWordTotal = vowelTotal;

            }

            MessageBox.Show("The word with the most vowels is: " + mostVowWord);
        }
        
        private void ExitBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
