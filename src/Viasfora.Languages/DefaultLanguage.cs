using System;
using System.ComponentModel.Composition;
using Winterdom.Viasfora.Languages.BraceScanners;
using Winterdom.Viasfora.Rainbow;
using Winterdom.Viasfora.Settings;

namespace Winterdom.Viasfora.Languages {
  public class DefaultLanguage : LanguageInfo, ILanguage {

    protected override String[] SupportedContentTypes => new String[0];
    public ILanguageSettings Settings { get; private set; }

    [ImportingConstructor]
    public DefaultLanguage(ITypedSettingsStore store) {
      this.Settings = new DefaultSettings(store);
    }

    public override Boolean MatchesContentType(Func<String, Boolean> _) {
      return true;
    }
    protected override IBraceScanner NewBraceScanner()
      => new DefaultBraceScanner();
  }

  public class DefaultSettings : LanguageSettings {
    protected override String[] ControlFlowDefaults => EMPTY;
    protected override String[] LinqDefaults => EMPTY;
    protected override String[] VisibilityDefaults => EMPTY;
    protected override String[] BracesDefaults => EMPTY;

    public DefaultSettings(ITypedSettingsStore store)
      : base ("Text", store) {
    }
  }
}
