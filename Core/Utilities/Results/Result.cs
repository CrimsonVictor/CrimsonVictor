using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //ReadOnly prop lar ctor yapısı ile set edilebilir.(etc.message)
        public Result(bool success, string message):this(success) //mesaj göndermek için ctor oluşturdum.
        {
            Message = message;
            //Success = success;      kod tekrarına düşme!!!
        }

        public Result(bool success) //overloading.
        {
            Success = success;      //tekrara düşmemek için success i burada set ettim.
        }                           //mesaj göndermek istemezsem bunu kullanabilirim.
                                    //yukarıdaki ctor a : this(success) ekleyerek.2 parametre gönderilince 2 parametre.1 parametre gönderilirse 1 parametre çalışır hale getirdim.
        public bool Success { get; }

        public string Message { get; }
    }
}
