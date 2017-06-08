using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace KontrolaOperacji
{
    class ZapisOdczyt<T>
    {
      
    
        public static void Serializacja(string path, T o){
            if(o != null)
                    {
                            using(var FS = new FileStream(path,FileMode.Create))
                            {
                                var bf = new BinaryFormatter();
                                bf.Serialize(FS, o);
                            }
                    }
            }
        public static T Deserializacja(string path)
        {
            T tmp = default(T);
            if(File.Exists(path))
            {
                using(var FS = new FileStream(path,FileMode.Open))
                {
                    if(FS.Length >0 )
                    {
                    var bf = new BinaryFormatter();
                    return (T)bf.Deserialize(FS);
                    }
                }
                
            }
            return tmp;
        }
    }
    class jakas
    {
        int i;
        int b;
        int c;
        int b;
    }
}

 