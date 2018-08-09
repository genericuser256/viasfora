using System;

namespace Winterdom.Viasfora.Languages {
  public interface ILanguageSettings {
    String KeyName { get; }
    String[] ControlFlow { get; set; }
    String[] Linq { get; set; }
    String[] Visibility { get; set; }
    String[] Braces { get; set; }
    bool Enabled { get; set; }
    void Load();
    void Save();
  }
}
