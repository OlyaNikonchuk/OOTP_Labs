using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_05
{
     public interface IGereric<T>
    {
        void Add(T item);
        void Delete(int index);
        void Show();
    }

    public interface IProduser
    {
        void Filmed();
    }

    public interface IBreak : IProduser
    {
        void Product();
        void ToTV();
    }
}
