using System;

namespace EM {
	
	public class Varchar  {

		private int size;

		public Varchar (int size) {
			this.size = size;
		}

		public String getSqlType(){
			return "VARCHAR("+this.size+")";
		}
	}

}

