using System;
using System.IO;
using GameConsoleSimulator.Util;
using SFML.Audio;
using SFML.Graphics;
using SFML.Window;

namespace GameConsoleSimulator.Models
{
    public class PlayStation4 : GameConsole
    {
        private RenderWindow mainDisplay;

        public PlayStation4()
        {
            DefaultVideoResolution = new Size(width: 1440, height: 900);
            var videoMode = new VideoMode(DefaultVideoResolution.Width, DefaultVideoResolution.Height);
            mainDisplay = new SFML.Graphics.RenderWindow(videoMode, "PS4");
        }
        
        public override AVInterface VideoConnectorType
        {
            get
            {
                //hint: you'll want to replace the line below with a "return <something>;" statement
                throw new Exception("PS4's get VideoConnectorType isn't implemented yet!");
            }
        }
        
        public override void StartUp()
        {
            showWelcomeScreen();
            playStartupSound();
        }

        private void playStartupSound()
        {
            string applicationDirectory = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            char slash = Path.DirectorySeparatorChar;
            String startupToneSoundFile = applicationDirectory + $"{slash}Assets{slash}Sounds{slash}PlayStation Startup Tone.flac";
            var startupToneSoundBuffer = new SoundBuffer(filename: startupToneSoundFile);
            SFML.Audio.Sound startupTone = new Sound(startupToneSoundBuffer);
            
            startupTone.Play();
        }

        private void showWelcomeScreen()
        {
            string applicationDirectory = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            char   slash                = Path.DirectorySeparatorChar;
            string welcomeImageFilePath = applicationDirectory + $"{slash}Assets{slash}Bitmaps{slash}PlayStationSymbols.gif";
            Stream welcomeImageFileStream = new FileStream(welcomeImageFilePath, FileMode.Open);
            Texture welcomeTexture = new Texture(welcomeImageFileStream);
            Sprite welcomeScreen = new Sprite(welcomeTexture);

            mainDisplay.Draw(welcomeScreen);
            mainDisplay.Display();
            mainDisplay.DispatchEvents();
        }
    }
}