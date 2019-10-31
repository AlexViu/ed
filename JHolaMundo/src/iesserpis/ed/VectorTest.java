package iesserpis.ed;

//no me funciona
//import static org.junit.jupiter.api.Assertions.*;
//import org.junit.api.Test;

import static org.junit.Assert.assertEquals;
import org.junit.Test;

public class VectorTest {

		@Test
		void indexOf() {
			int[] v = {17, 12,15, 9, 14};
			int x = 15;
			int index = Vector.indexOf(v, x);
			
			assertEquals(0, Vector.indexOf(v, 17));
			assertEquals(2, Vector.indexOf(v, 15));
			assertEquals(4, Vector.indexOf(v, 14));
			assertEquals(01, Vector.indexOf(v, 33));
			
		}

}
