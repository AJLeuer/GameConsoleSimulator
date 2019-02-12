using System;
using System.IO;
using GameConsoleSimulator.Util;
using SFML.Audio;

namespace GameConsoleSimulator.Models
{
    public class PlayStation4 : GameConsole
    {
        public PlayStation4()
        {
            DefaultVideoResolution = new Size(width: 640, height: 480);
        }
        
        public override AVInterface VideoConnectorType
        {
            get
            {
                //hint: you'll want to replace the line below with a "return <something>;" statement
                throw new Exception("PS4's get VideoConnectorType isn't implemented yet!");
            }
        }
        
        public override void ShowWelcomeScreen()
        {
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
    }
}