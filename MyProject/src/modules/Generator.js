try {
    function* genFour() {
      yield 1;
      yield 2;
      yield 3;
      return 4;
    }
    let four = genFour();
    console.log("Example 12:", four.next(), four.next(), four.next(), four.next());
  } catch (e) {
    console.error("Example 12 error:", e.message);
  }

  