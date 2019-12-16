package iesserpis.ed;

import java.util.Arrays;

public class Vector {

	public static void main(String[] args) {

	}

	public static int max(int[] v) {
		int max = v[0];
		for (int index = 1; index < v.length; index++) {

			if (v[index] > max) {
				max = v[index];
			}
		}
		return max;
	}

	public static int[] selectionSort(int[] v1) {
		Arrays.sort(v1);
		return v1;
	}

}
