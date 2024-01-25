using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace archivosTextoTSM
{
    public class Contacto
    {

        private int id;
        private string name;
        private int phone;

        public Contacto() { }

        public Contacto(int id, string name, int phone)
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Phone { get => phone; set => phone = value; }

        public override string ToString()
        {
            return "  --Datos de contacto--\nId: " + id + "\nNombre: " + name + "\nTelefono: " + phone;
        }


    }
}
