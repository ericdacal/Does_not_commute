using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;


/*namespace Utils
{
	enum Type {RIGHT, LEFT};
	
	public struct Event 
	{
		public int type; 
		public float time;
	}
	
	public class Record 
	{
		Stopwatch watch;
		List<Events.Event> events;

		void printEvents() 
		{
			foreach (Events.Event e in events)
			{
				print(e.time);
			}
		}

		// Use this for initialization
		void start () 
		{
			events = new List<Events.Event>();
			watch = new Stopwatch();
			watch.Start();
			
		}

		void computeEvent(Event e) 
		{
			
		}
		
		// Update is called once per frame
		void Update () 
		{
			if (Input.GetKeyDown(KeyCode.D))
			{
				Events.Event e;
				e.type = (int)Type.LEFT;
				e.time = watch.ElapsedMilliseconds;
				events.Add(e);
				print("D");
			}
			if (Input.GetKeyDown(KeyCode.A))
			{
				print("A");
				Events.Event e;
				e.type = (int)Type.RIGHT;
				e.time = watch.ElapsedMilliseconds;
				events.Add(e);
			} 	
			//printEvents();
		}
	}
}*/
