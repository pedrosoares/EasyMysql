using System;
using System.Collections;
using System.Collections.Generic;

namespace EM {

	public class Result {
		private List<Value> value = new List<Value> ();
		
		public void addValue(Value value){
			this.value.Add(value);
		}
		
		public List<Value> getValues(){
			return this.value;
		}
	}

}

