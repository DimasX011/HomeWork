using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmLesson4
{
   public class TreeNode
    {
        public int Value { get; set; }

        public TreeNode LeftChild { get; set; }

        public TreeNode RightChild { get; set; }

        public override bool Equals(object obj)
        {
            var node = obj as TreeNode;

            if (node == null)
                return false;

            return node.Value == Value;
        }

    }

    public interface Itree
    {
        TreeNode GetRoot();
        void AddItem(int value);//добавить узел

        void RemoveItem(int value);

        TreeNode GetNodeByValue(int value);// получить узел дерева по значению

        void PrintTree();//вывести дерево в консоль
    }

}
