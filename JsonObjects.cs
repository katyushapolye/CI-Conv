using System;
using System.IO;
using System.Text;
using DataStructs;

 namespace JsonObjects
{

    public abstract class RawJsonObject
    {
        public string RawJson;

        public RawJsonObject(ref string Adress, Encoding Enc)
        {

            System.IO.FileStream buffer = File.OpenRead(Adress);
            System.IO.StreamReader reader = new System.IO.StreamReader(buffer, encoding: Enc);
            RawJson = reader.ReadToEnd();

        }


    }

    public class ePistolariumObject : RawJsonObject
    {
        public ePistolariumNetwork Network;
       
        public ePistolariumObject(string Adress, Encoding Encoding) : base(ref Adress,Encoding)
        {
            
            this.Network = Newtonsoft.Json.JsonConvert.DeserializeObject<DataStructs.ePistolariumNetwork>(RawJson);

        }


        //Make line break happen with an custom header...
        public void ToCSV(ref string Adress,bool IsDivided, string Link_Header = "Source,Target,Type,Id,Label,timeset,Weight\n", string Node_Header = "Id,Label,timeset \n", bool CarryWeigh = false) 
        {
            FileStream Link_File = File.Create(@"ResultFiles\" + Adress + "_Links.csv");
            FileStream Node_File = File.Create(@"ResultFiles\" + Adress + "_Nodes.csv");

            //Writes The Headers.
            byte[] Header_Buffer = Encoding.UTF8.GetBytes(Link_Header);
            Link_File.Write(Header_Buffer,0,Header_Buffer.Length);
            Array.Clear(Header_Buffer, 0, Header_Buffer.Length);
            Header_Buffer = Encoding.UTF8.GetBytes(Node_Header);
            Node_File.Write(Header_Buffer, 0, Header_Buffer.Length) ;
            Array.Clear(Header_Buffer, 0, Header_Buffer.Length);


            WriteLinks(ref Link_File,CarryWeigh);
            WriteNodes(ref Node_File);


            Link_File.Flush();
            Node_File.Flush();
            Link_File.Close();
            Node_File.Close();
        }
        private void WriteLinks(ref FileStream file,bool Weight) 
        {
            //fix weight
            byte[] Link_Buffer;
            
            for (int i = 0; i < this.Network.links.Count; i++)
            {
                if(Weight == true)
                {
                    Link_Buffer = Encoding.UTF8.GetBytes(Network.links[i].source.ToString() + "," + Network.links[i].target.ToString() + ",Undirected," + i.ToString() + ",,," + Network.links[i].w + "\n");
                    file.Write(Link_Buffer, 0, Link_Buffer.Length);
                    Array.Clear(Link_Buffer, 0, Link_Buffer.Length);
                    continue;

                }
                else
                {
                    Link_Buffer = Encoding.UTF8.GetBytes(Network.links[i].source.ToString() + "," + Network.links[i].target.ToString() + ",Undirected," + i.ToString() + ",,,1" + "\n");
                    file.Write(Link_Buffer, 0, Link_Buffer.Length);
                    Array.Clear(Link_Buffer, 0, Link_Buffer.Length);
                    continue;
                                    }
             

            }
        }
        private void WriteNodes(ref FileStream file)
        {
            byte[] Node_Buffer;
            for (int i = 0; i < this.Network.nodes.Count; i++)
            {
                string[] vs = this.Network.nodes[i].name.Split(',');
                if (vs.Length == 1)
                {
                    Node_Buffer = Encoding.UTF8.GetBytes(i.ToString() + "," + vs[0].ToString() + ", \n");
                    file.Write(Node_Buffer, 0, Node_Buffer.Length) ;
                    Array.Clear(Node_Buffer, 0, Node_Buffer.Length);
                    continue;

                }
                else 
                {
                    Node_Buffer = Encoding.UTF8.GetBytes(i.ToString() + "," +vs[1].ToString().Remove(0,1) + " " + vs[0].ToString() + ", \n");
                    file.Write(Node_Buffer,0,Node_Buffer.Length);
                    Array.Clear(Node_Buffer, 0, Node_Buffer.Length);
                    continue;

                }
            }

        }
    }
}








