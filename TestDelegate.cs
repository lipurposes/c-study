using System;
namespace firstStudy{
    class TestDelegate{

        public TestDelegate(){
            checkFunc = isNumEven;
        }
        public delegate bool checkIsEven(int num);
        public checkIsEven checkFunc;

        public bool isNumEven(int num){
            return num % 2 == 0;
        }
    }
}