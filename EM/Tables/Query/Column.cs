using System;

namespace EM {

	public class Column {

		public string name;

		public TypeColumn type;
		public int size;

		public Column(String name, TypeColumn type, int size){
			this.name = name;
			this.type = type;
			this.size = size;
		}

		public Column(String name, TypeColumn type){
			this.name = name;
			this.type = type;
		}
		
		public String GetTypeColumn(){
			switch(type){
				case(TypeColumn.VARCHAR):
					return "VARCHAR("+this.size+")";
					
				default:
					return this.type.ToString();
			}
		}
	}

}

