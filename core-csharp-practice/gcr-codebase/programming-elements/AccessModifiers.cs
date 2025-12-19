using System;
class AccessModifiers{
    static void Main(String[] args){
	
//Access Modifiers

//private --- The strictest modifier. The code is only visible inside the class where it is defined.

	private int privateData = 10;

//private protected --- Visible inside the class AND in classes that inherit from it, but only if they are in the same project/assembly.

	private protected int privproData = 100;

//internal --- Visible to any code in the same project (Assembly/.dll), but hidden from other projects referencing it.

	internal int internalData = 1000;

//protected --- Visible inside the class AND any class that inherits from it (even in other projects).

	protected int protectedData = 10000;

//protected internal --- Visible to the same project OR any class that inherits from it (Union of protected and internal).

	protected internal int prointernalData = 100000;

//public --- No restrictions. Can be accessed by any code in any project.

	public int publicData = 1000000;



} 

}