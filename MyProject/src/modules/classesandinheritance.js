try {
    class AegonTargarean {
      constructor() {
        this.VallarMorhillis = false;
      }
      toString() {
        return (this.VallarMorhillis ? 'Join' : 'All hail Targarean') + ' Bow to them';
      }
    }
  
    class MotherofDragon extends AegonTargarean {
      constructor() {
        super();
        this.VallarMorhillis = true;
      }
    }
  
    const khaleesi = new MotherofDragon();
    console.log("Example 5:", khaleesi.toString());
  } catch (e) {
    console.error("Example 5 error:", e.message);
  }
  