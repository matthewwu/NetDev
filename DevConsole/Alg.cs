/*
 * Created by SharpDevelop.
 * User: user
 * Date: 7/17/2014
 * Time: 2:32 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using System.Collections.Generic;

namespace DevConsole
{
	/// <summary>
	/// Description of Alg.
	/// </summary>
	public class Alg
	{
		public Alg()
		{
		}
		
		public List<T[]> GetPermintation<T>(T[] l)
		{
			List<T[]> result = new List<T[]>();
			
			for(int i=0;i<l.Length;i++)
			{
				T[] remainingP = new T[l.Length-1]();
				for(int j=0;j<i;j++)
				{
					
				}
				List<T> pThis = new List<T>(){l[i]};
				
			}
			
			return result;
		}
				
	}
}
