package iesserpis.ed;

public class Vector {

	public static void main(String[] args) {
		
		int[] v = new int[] {17, 12, 15, 9, 14};
		int x = 9;
		int index = indexOf(v , x);
		System.out.println("index=" + index);
		System.out.println("fin");
		
		//for (i=0; i <=4; i++) {
		//System.out.println(v[i]);
		//}
		//System.out.println("fin");
		
	}

	private static int indexOf(int[] v, int x) {
		int index = 0;
		while (index < 5 && v[index]!=x) {
			index ++;
		}
		if (index == 5)
			return -1;
			return index;
	}
}
