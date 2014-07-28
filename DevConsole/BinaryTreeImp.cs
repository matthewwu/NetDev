/*
 * Created by SharpDevelop.
 * User: user
 * Date: 7/17/2014
 * Time: 10:33 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace DevConsole
{
	/// <summary>
	/// Description of BinaryTreeImp.
	/// </summary>
	public class BinaryTreeImp<K,V>
		where K: class,IComparable<K>
		where V: class
	{
		private BinaryTreeNode<K,V> root;
		public BinaryTreeImp()
		{
			root = null;
		}
		
		public void InsertNode(BinaryTreeNode<K,V> node)
		{
			InsertNodeImp(root,node);
		}
		
		public V GetValue(K key)
		{
			return GetValueImp(root,key);
		}
				
		
		private V GetValueImp(BinaryTreeNode<K,V> currentRoot, K key)
		{
			
			if(currentRoot == null)
			{
				return null;
			}
			
			if(key.CompareTo(currentRoot.Key) == 0)
			{
				return currentRoot.Value;
			}						
			
			if(key.CompareTo(currentRoot.Key) < 0)
			{				
				return GetValueImp(currentRoot.Left, key);				
			}
			else
			{				
				return GetValueImp(currentRoot.Right,key);				
			}
		}
		
		private void InsertNodeImp(BinaryTreeNode<K,V> currentRoot, BinaryTreeNode<K,V> node)
		{
			if(currentRoot == null)
			{
				currentRoot = node;
				return;
			}
			
			if(node.Key.CompareTo(currentRoot.Key) < 0)
			{				
				InsertNodeImp(currentRoot.Left,node);				
			}
			else
			{				
				InsertNodeImp(currentRoot.Right,node);				
			}
		}
	}
	
	public class BinaryTreeNode<K,V>
		where K: class,IComparable<K>
		where V: class
	{
		public K Key{get;set;}
		public V Value{get;set;}
		public BinaryTreeNode<K,V> Left{get;set;}
		public BinaryTreeNode<K,V> Right{get;set;}
	}
}
