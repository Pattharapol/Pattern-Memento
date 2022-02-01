using Pattern_memento;
using System;

namespace pattern_memento
{
    class Program
    {
        static void Main(string[] args)
        {
            var stateManager = new CareTaker<Editor>();
            var editor = new Editor("T1", "text1", 14, "TH SarabunPSK1");
            Console.WriteLine(editor);

            var state1 = editor.CreateState();
            stateManager.PushMemento(state1);

            editor = new Editor("T2", "text2", 15, "TH SarabunPSK2");
            Console.WriteLine(editor);
            stateManager.PushMemento(editor.CreateState());

            editor = new Editor("T3", "text3", 16, "TH SarabunNEW3");
            Console.WriteLine(editor);

            var undoState = stateManager.Undo();
            editor.RestoreState(undoState);
            Console.WriteLine(editor);

            editor.RestoreState(stateManager.Undo());
            Console.WriteLine(editor);

            editor.RestoreState(stateManager.Redo());
            Console.WriteLine(editor);

            editor = new Editor("T3", "text3", 16, "TH SarabunNEW3");
            Console.WriteLine(editor);
            stateManager.PushMemento(editor.CreateState());

            editor = new Editor("T4", "text4", 17, "TH SarabunNEW4");
            Console.WriteLine(editor);

            editor.RestoreState(stateManager.Undo());
            Console.WriteLine(editor);
        }
    }
}
