using System;

public class Insult {
  public String ComeBack { get; set; }
  private String _insult;
  public Insult(String insult) {
    _insult = insult;
  }
  public override String ToString() {
    return String.Format(
      "Insult: {0}, Comeback: {1}",
      this._insult,
      this.ComeBack
    );
  }
}