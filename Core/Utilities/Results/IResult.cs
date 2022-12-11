using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    //temel voidler için başlangıç
    public interface IResult
    {
        bool Success { get; } //get sadece okumak için.(işlem başarılı mı değil mi)
        string Message { get; } //ürün eklendi.(işlem başarılı.),ürün eklenemedi (işlem başarısız.)
    }
}
