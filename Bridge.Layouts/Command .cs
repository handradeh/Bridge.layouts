using System;

namespace Bridge.Layouts
{
    [External]
    [Namespace("layouts")]
    public class Command
    {

        public delegate void executeHandler(Command command, object parameter);
        public delegate bool canExecuteHandler(Command command, object parameter);

        public Command(executeHandler exch, canExecuteHandler cExh)
        {

        }



        ////        constructor(executeHandler?: {
        ////    (command: Command, parameter: any): void;
        ////}, canExecuteHandler?: {
        ////            (command: Command, parameter: any): boolean;
        ////        });
        ////public bool canExecute(object parameter) {
        ////    return default(bool);
        ////}//: boolean;
        //public void execute(object parameter) { }//: void;
        //private object[] handlers;
        public executeHandler onCanExecuteChangeNotify; //: void;
        //public executeHandler offCanExecuteChangeNotify(object handler) { return default(executeHandler); }//: void;
        public void canExecuteChanged()
        {
            return;
        }//: void;      
    }
}