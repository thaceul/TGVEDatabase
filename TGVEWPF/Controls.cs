using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGVEWPF
    {
        public class Control
        {
            public DataHandler DH;

            public Control(Home home)
            {
                DH = new DataHandler("http://localhost:51306/");

                Home = home;
                Events = new Events(this);
                Bookings = new Bookings(this);
                Clients = new Clients(this);
            }

            public Home Home { get; set; }
            public Events Events { get; set; }
            public Bookings Bookings { get; set; }
            public Clients Clients { get; set; }
        }
    }

}
}
