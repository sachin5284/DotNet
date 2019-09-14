// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/h2h.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code
using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
namespace Tennis
{

    /// <summary>Holder for reflection information generated from Protos/h2h.proto</summary>
    public static partial class H2HReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/h2h.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static H2HReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChBQcm90b3MvaDJoLnByb3RvEgZUZW5uaXMiLgoKSDJIUmVxdWVzdBIPCgdQ",
            "bGF5ZXIxGAEgASgJEg8KB1BsYXllcjIYAiABKAkiNwoISDJIUmVwbHkSDAoE",
            "V29uMRgBIAEoDRIMCgRXb24yGAIgASgNEg8KB3N1Y2Nlc3MYAyABKAgiMwoP",
            "SDJITXVsdGlSZXF1ZXN0Eg4KBlBsYXllchgBIAEoCRIQCghPcHBvbmVudBgC",
            "IAMoCSJTCg1IMkhNdWx0aVJlcGx5EiAKB1BsYXllcjEYASABKAsyDy5UZW5u",
            "aXMuSDJISXRlbRIgCgdQbGF5ZXIyGAIgASgLMg8uVGVubmlzLkgySEl0ZW0i",
            "JAoHSDJISXRlbRIMCgROYW1lGAEgASgJEgsKA1dvbhgCIAEoDTKzAQoDSDJI",
            "EjEKB0RldGFpbHMSEi5UZW5uaXMuSDJIUmVxdWVzdBoQLlRlbm5pcy5IMkhS",
            "ZXBseSIAEjUKC0RldGFpbHNEZW1vEhIuVGVubmlzLkgySFJlcXVlc3QaEC5U",
            "ZW5uaXMuSDJIUmVwbHkiABJCCgxNdWx0aURldGFpbHMSFy5UZW5uaXMuSDJI",
            "TXVsdGlSZXF1ZXN0GhUuVGVubmlzLkgySE11bHRpUmVwbHkiADABYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Tennis.H2HRequest), global::Tennis.H2HRequest.Parser, new[]{ "Player1", "Player2" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Tennis.H2HReply), global::Tennis.H2HReply.Parser, new[]{ "Won1", "Won2", "Success" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Tennis.H2HMultiRequest), global::Tennis.H2HMultiRequest.Parser, new[]{ "Player", "Opponent" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Tennis.H2HMultiReply), global::Tennis.H2HMultiReply.Parser, new[]{ "Player1", "Player2" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Tennis.H2HItem), global::Tennis.H2HItem.Parser, new[]{ "Name", "Won" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Send the code of the players
  /// </summary>
  public sealed partial class H2HRequest : pb::IMessage<H2HRequest> {
    private static readonly pb::MessageParser<H2HRequest> _parser = new pb::MessageParser<H2HRequest>(() => new H2HRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<H2HRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tennis.H2HReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public H2HRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public H2HRequest(H2HRequest other) : this() {
      player1_ = other.player1_;
      player2_ = other.player2_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public H2HRequest Clone() {
      return new H2HRequest(this);
    }

    /// <summary>Field number for the "Player1" field.</summary>
    public const int Player1FieldNumber = 1;
    private string player1_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Player1 {
      get { return player1_; }
      set {
        player1_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Player2" field.</summary>
    public const int Player2FieldNumber = 2;
    private string player2_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Player2 {
      get { return player2_; }
      set {
        player2_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as H2HRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(H2HRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Player1 != other.Player1) return false;
      if (Player2 != other.Player2) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Player1.Length != 0) hash ^= Player1.GetHashCode();
      if (Player2.Length != 0) hash ^= Player2.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Player1.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Player1);
      }
      if (Player2.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Player2);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Player1.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Player1);
      }
      if (Player2.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Player2);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(H2HRequest other) {
      if (other == null) {
        return;
      }
      if (other.Player1.Length != 0) {
        Player1 = other.Player1;
      }
      if (other.Player2.Length != 0) {
        Player2 = other.Player2;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Player1 = input.ReadString();
            break;
          }
          case 18: {
            Player2 = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Get the history of the played matches
  /// </summary>
  public sealed partial class H2HReply : pb::IMessage<H2HReply> {
    private static readonly pb::MessageParser<H2HReply> _parser = new pb::MessageParser<H2HReply>(() => new H2HReply());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<H2HReply> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tennis.H2HReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public H2HReply() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public H2HReply(H2HReply other) : this() {
      won1_ = other.won1_;
      won2_ = other.won2_;
      success_ = other.success_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public H2HReply Clone() {
      return new H2HReply(this);
    }

    /// <summary>Field number for the "Won1" field.</summary>
    public const int Won1FieldNumber = 1;
    private uint won1_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Won1 {
      get { return won1_; }
      set {
        won1_ = value;
      }
    }

    /// <summary>Field number for the "Won2" field.</summary>
    public const int Won2FieldNumber = 2;
    private uint won2_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Won2 {
      get { return won2_; }
      set {
        won2_ = value;
      }
    }

    /// <summary>Field number for the "success" field.</summary>
    public const int SuccessFieldNumber = 3;
    private bool success_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Success {
      get { return success_; }
      set {
        success_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as H2HReply);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(H2HReply other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Won1 != other.Won1) return false;
      if (Won2 != other.Won2) return false;
      if (Success != other.Success) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Won1 != 0) hash ^= Won1.GetHashCode();
      if (Won2 != 0) hash ^= Won2.GetHashCode();
      if (Success != false) hash ^= Success.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Won1 != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Won1);
      }
      if (Won2 != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Won2);
      }
      if (Success != false) {
        output.WriteRawTag(24);
        output.WriteBool(Success);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Won1 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Won1);
      }
      if (Won2 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Won2);
      }
      if (Success != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(H2HReply other) {
      if (other == null) {
        return;
      }
      if (other.Won1 != 0) {
        Won1 = other.Won1;
      }
      if (other.Won2 != 0) {
        Won2 = other.Won2;
      }
      if (other.Success != false) {
        Success = other.Success;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Won1 = input.ReadUInt32();
            break;
          }
          case 16: {
            Won2 = input.ReadUInt32();
            break;
          }
          case 24: {
            Success = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Send the code of the players
  /// </summary>
  public sealed partial class H2HMultiRequest : pb::IMessage<H2HMultiRequest> {
    private static readonly pb::MessageParser<H2HMultiRequest> _parser = new pb::MessageParser<H2HMultiRequest>(() => new H2HMultiRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<H2HMultiRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tennis.H2HReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public H2HMultiRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public H2HMultiRequest(H2HMultiRequest other) : this() {
      player_ = other.player_;
      opponent_ = other.opponent_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public H2HMultiRequest Clone() {
      return new H2HMultiRequest(this);
    }

    /// <summary>Field number for the "Player" field.</summary>
    public const int PlayerFieldNumber = 1;
    private string player_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Player {
      get { return player_; }
      set {
        player_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Opponent" field.</summary>
    public const int OpponentFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _repeated_opponent_codec
        = pb::FieldCodec.ForString(18);
    private readonly pbc::RepeatedField<string> opponent_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> Opponent {
      get { return opponent_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as H2HMultiRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(H2HMultiRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Player != other.Player) return false;
      if(!opponent_.Equals(other.opponent_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Player.Length != 0) hash ^= Player.GetHashCode();
      hash ^= opponent_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Player.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Player);
      }
      opponent_.WriteTo(output, _repeated_opponent_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Player.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Player);
      }
      size += opponent_.CalculateSize(_repeated_opponent_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(H2HMultiRequest other) {
      if (other == null) {
        return;
      }
      if (other.Player.Length != 0) {
        Player = other.Player;
      }
      opponent_.Add(other.opponent_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Player = input.ReadString();
            break;
          }
          case 18: {
            opponent_.AddEntriesFrom(input, _repeated_opponent_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Get the history of the played matches
  /// </summary>
  public sealed partial class H2HMultiReply : pb::IMessage<H2HMultiReply> {
    private static readonly pb::MessageParser<H2HMultiReply> _parser = new pb::MessageParser<H2HMultiReply>(() => new H2HMultiReply());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<H2HMultiReply> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tennis.H2HReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public H2HMultiReply() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public H2HMultiReply(H2HMultiReply other) : this() {
      player1_ = other.player1_ != null ? other.player1_.Clone() : null;
      player2_ = other.player2_ != null ? other.player2_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public H2HMultiReply Clone() {
      return new H2HMultiReply(this);
    }

    /// <summary>Field number for the "Player1" field.</summary>
    public const int Player1FieldNumber = 1;
    private global::Tennis.H2HItem player1_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Tennis.H2HItem Player1 {
      get { return player1_; }
      set {
        player1_ = value;
      }
    }

    /// <summary>Field number for the "Player2" field.</summary>
    public const int Player2FieldNumber = 2;
    private global::Tennis.H2HItem player2_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Tennis.H2HItem Player2 {
      get { return player2_; }
      set {
        player2_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as H2HMultiReply);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(H2HMultiReply other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Player1, other.Player1)) return false;
      if (!object.Equals(Player2, other.Player2)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (player1_ != null) hash ^= Player1.GetHashCode();
      if (player2_ != null) hash ^= Player2.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (player1_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Player1);
      }
      if (player2_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Player2);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (player1_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Player1);
      }
      if (player2_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Player2);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(H2HMultiReply other) {
      if (other == null) {
        return;
      }
      if (other.player1_ != null) {
        if (player1_ == null) {
          Player1 = new global::Tennis.H2HItem();
        }
        Player1.MergeFrom(other.Player1);
      }
      if (other.player2_ != null) {
        if (player2_ == null) {
          Player2 = new global::Tennis.H2HItem();
        }
        Player2.MergeFrom(other.Player2);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (player1_ == null) {
              Player1 = new global::Tennis.H2HItem();
            }
            input.ReadMessage(Player1);
            break;
          }
          case 18: {
            if (player2_ == null) {
              Player2 = new global::Tennis.H2HItem();
            }
            input.ReadMessage(Player2);
            break;
          }
        }
      }
    }

  }

  public sealed partial class H2HItem : pb::IMessage<H2HItem> {
    private static readonly pb::MessageParser<H2HItem> _parser = new pb::MessageParser<H2HItem>(() => new H2HItem());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<H2HItem> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tennis.H2HReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public H2HItem() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public H2HItem(H2HItem other) : this() {
      name_ = other.name_;
      won_ = other.won_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public H2HItem Clone() {
      return new H2HItem(this);
    }

    /// <summary>Field number for the "Name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Won" field.</summary>
    public const int WonFieldNumber = 2;
    private uint won_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Won {
      get { return won_; }
      set {
        won_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as H2HItem);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(H2HItem other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Won != other.Won) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Won != 0) hash ^= Won.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Won != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Won);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Won != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Won);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(H2HItem other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Won != 0) {
        Won = other.Won;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 16: {
            Won = input.ReadUInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code