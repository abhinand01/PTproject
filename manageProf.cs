using System;
namespace manageProf {

    class manageProf {
        private string[] namelist = new string[size];
        static public int size = 5;

        public manageProf () {
            for (int i = 0; i < size; i++)
                namelist[i] = "Kids";
        }
        public string this [int index] {
            get {
                string tmp;

                if (index >= 0 && index <= size - 1) {
                    tmp = namelist[index];
                } else {
                    tmp = "";
                }

                return (tmp);
            }
            set {
                if (index >= 0 && index <= size - 1) {
                    namelist[index] = value;
                }
            }
        }

    }

}