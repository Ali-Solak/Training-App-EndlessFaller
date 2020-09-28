using System;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

public class HighScoreXML
{
    private string path;
	
    public HighScoreXML()
    {
        path = Application.persistentDataPath + "/highScore.xml";
  
    }

    public void saveHighscore(int highScore)
    {
        FileStream fstream = new FileStream(path, FileMode.Create);
        BinaryFormatter formatter = new BinaryFormatter();
        
        try
        {
            formatter.Serialize(fstream, highScore);
        }
        catch (SerializationException e)
        {
            Console.WriteLine("Failed to serialize. Reason: " + e.Message);
            throw;
        }
        finally
        {
            fstream.Close();
        }
    }

    public int load()
    {
        if (File.Exists(path))
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            
            try
            {
                int highscore = (int) formatter.Deserialize(fs);

                return highscore;
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }
            
        }
        return 0;
    }
}

