using System;

namespace firstStudy{
    class Persion
    {
        private int m_age;
        public int age
        {
            get
            {
                return m_age;
            }
            set
            {
                m_age = value;
            }
        }
        public string Name { get; set; }

        public void test(){
            Console.WriteLine("Persion test");
        }
    }

    class Man : Persion{
        public void test(){
            base.test();
            Console.WriteLine("you call base test");
        }
    }
}
