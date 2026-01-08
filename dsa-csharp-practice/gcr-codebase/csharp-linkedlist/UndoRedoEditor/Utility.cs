using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.LinkedList.UndoRedoEditor
{
    public class Utility
    {
        public static void Main(string[] args)
        {
            EditorList editor = new EditorList();
            editor.AddState("Hello");
            editor.DisplayCurrent();

            editor.AddState("Hello World");
            editor.DisplayCurrent();

            editor.AddState("Hello World 2023");
            editor.DisplayCurrent();

            Console.WriteLine("\nTesting Undo:");
            editor.Undo();
            editor.Undo();

            Console.WriteLine("\nTesting Redo:");
            editor.Redo();

            Console.WriteLine("\nNew Action (Clears Redo history):");
            editor.AddState("Hello C#");
            editor.DisplayCurrent();
            editor.Redo();
        }
    }
}
