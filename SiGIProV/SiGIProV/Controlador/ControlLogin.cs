using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiGIProV.DAO;

namespace SiGIProV.Controlador
{
    class ControlLogin
    {
        //Este método redirige la información de la interfaz Login a la base de datos (DAO)
        public string controlLoginDAO(string user, string pass)
        {
            DAOusuario daolog = new DAOusuario();
            String confirmar = daolog.Login(user, pass);
            return confirmar;
        }   

    }

}
