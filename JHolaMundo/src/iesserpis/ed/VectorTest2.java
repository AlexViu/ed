package iesserpis.ed;

import static org.junit.Assert.assertEquals;
import static org.junit.jupiter.api.Assertions.*;

import org.junit.jupiter.api.Test;

class VectorTest2 {

	@Test
	void max() {
		assertEquals(21, Vector.max((new int []{14,21,12,9,7})));
	}

	@Test
			void selectionSort() {
				int[] v1 = {14, 21, 12, 7, 9};
				Vector.selectionSort(v1);
				assertArrayEquals(new int[] {7, 9, 12, 14, 21}, v1);
			}
}
