using System;

namespace EM {
	public class Value {
		private Column column;
		
		private String s_value;
		private float  f_value;
		private bool   b_value;
		private double d_value;


		public Value (){}

		public Value(Column column, Object value){
			this.column = column;
			switch(column.type){
				case(TypeColumn.VARCHAR):
					this.s_value = (String) value;
				break;
					
				case(TypeColumn.TEXT):
					this.s_value = (String) value;
				break;
					
				case(TypeColumn.BOOLEAN):
					this.b_value = (bool) value;
				break;
					
				case(TypeColumn.LONGBLOB):
					this.s_value = (String) value;
				break;	
					
				case(TypeColumn.BLOB):
					this.s_value = (String) value;
				break;	
					
				case(TypeColumn.FLOAT):
					this.f_value = (float) value;
				break;	
					
				case(TypeColumn.DOUBLE):
					this.d_value = (double) value;
				break;	
			}
		}

		public Value(String columnName, TypeColumn type, Object value){
			this.column = new Column (columnName, type);
			switch(type){
				case(TypeColumn.VARCHAR):
					this.s_value = (String) value;
				break;
					
				case(TypeColumn.TEXT):
					this.s_value = (String) value;
				break;
					
				case(TypeColumn.BOOLEAN):
					this.b_value = (bool) value;
				break;
					
				case(TypeColumn.LONGBLOB):
					this.s_value = (String) value;
				break;	
					
				case(TypeColumn.BLOB):
					this.s_value = (String) value;
				break;	
					
				case(TypeColumn.FLOAT):
					this.f_value = (float) value;
				break;	
					
				case(TypeColumn.DOUBLE):
					this.d_value = (double) value;
				break;	
			}
		}
		
		public void setColumn(Column column){
			this.column = column;
		}

		public void setColumn(String columnName, TypeColumn type){
			this.column = new Column (columnName, type);
		}
		
		public Column getColumn(){
			return column;
		}

		public void setValue(Object value){
			if (this.column != null) {
				switch(this.column.type){
				case(TypeColumn.VARCHAR):
					this.s_value = (String) value;
					break;
					
				case(TypeColumn.TEXT):
					this.s_value = (String) value;
					break;
					
				case(TypeColumn.BOOLEAN):
					this.b_value = (bool) value;
					break;
					
				case(TypeColumn.LONGBLOB):
					this.s_value = (String) value;
					break;	
					
				case(TypeColumn.BLOB):
					this.s_value = (String) value;
					break;	
					
				case(TypeColumn.FLOAT):
					this.f_value = (float) value;
					break;	
					
				case(TypeColumn.DOUBLE):
					this.d_value = (double) value;
					break;	
				}
			}
		}
		
		public void setValue(TypeColumn type, Object value){
			switch(type){
			case(TypeColumn.VARCHAR):
				this.s_value = (String) value;
				break;
				
			case(TypeColumn.TEXT):
				this.s_value = (String) value;
				break;
				
			case(TypeColumn.BOOLEAN):
				this.b_value = (bool) value;
				break;
				
			case(TypeColumn.LONGBLOB):
				this.s_value = (String) value;
				break;	
				
			case(TypeColumn.BLOB):
				this.s_value = (String) value;
				break;	
				
			case(TypeColumn.FLOAT):
				this.f_value = (float) value;
				break;	
				
			case(TypeColumn.DOUBLE):
				this.d_value = (double) value;
				break;	
			}
		}
		
		public Object getValue(){
			switch(column.type){
			case(TypeColumn.VARCHAR):
				return this.s_value;
				
				
			case(TypeColumn.TEXT):
				return this.s_value;
				
				
			case(TypeColumn.BOOLEAN):
				return this.b_value;
				
				
			case(TypeColumn.LONGBLOB):
				return this.s_value;
				
				
			case(TypeColumn.BLOB):
				return this.s_value;
				
				
			case(TypeColumn.FLOAT):
				return this.f_value;
				
				
			case(TypeColumn.DOUBLE):
				return this.d_value;
				
			}
			return null;
		}
	}
}

