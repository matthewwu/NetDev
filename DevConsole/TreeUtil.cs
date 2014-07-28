using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevConsole
{

    public class Tree<K, V>
        where K : class, IComparable<K>
        where V : class
    {
        private Node<K, V> root;

        public V BFS(K key)
        {
            Queue<Node<K, V>> queue = new Queue<Node<K, V>>();

            while (queue.Any())
            {
                var node = queue.Dequeue();

                if (node.key == key)
                {
                    return node.value;
                }
                foreach (var child in node.children)
                {
                    queue.Enqueue(child);
                }
            }
            return default(V);
        }

        private class Node<K, V>
            where K : class, IComparable<K>
            where V : class
        {
            public K key;
            public V value;
            public Node<K, V>[] children;
        }
    }

    public class TreeUtil
    {

        public void DFS(TreeNode node)
        {
            if (node.children != null)
            {
                int myData = node.data;

                foreach (var child in node.children)
                {
                    DFS(child);
                }
            }
        }

        public void BFS(TreeNode node)
        {
            if (node.children != null)
            {
                int myData = node.data;

                foreach (var child in node.children)
                {
                    int childData = child.data;
                }
                

            }
        }

        public void Test()
        {
            
        }
    }

    public class TreeNode
    {
        public int data;
        public List<TreeNode> children;
    }
}
