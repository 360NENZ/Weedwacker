// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Unk2700_KLJLJGJOBDI.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from Unk2700_KLJLJGJOBDI.proto</summary>
  public static partial class Unk2700KLJLJGJOBDIReflection {

    #region Descriptor
    /// <summary>File descriptor for Unk2700_KLJLJGJOBDI.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Unk2700KLJLJGJOBDIReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlVbmsyNzAwX0tMSkxKR0pPQkRJLnByb3RvGhlVbmsyNzAwX05DTlBOTUZG",
            "T05HLnByb3RvIooBChNVbmsyNzAwX0tMSkxKR0pPQkRJEhsKE1VuazI3MDBf",
            "Q0RET05KSk1GQ0kYCCABKA0SJAoGcmVhc29uGAcgASgOMhQuVW5rMjcwMF9O",
            "Q05QTk1GRk9ORxITCgtmaW5hbF9zY29yZRgNIAEoDRIbChNVbmsyNzAwX0ZG",
            "Q0NMR0lGR0lQGA8gASgNQiKqAh9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3Jr",
            "LlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.Unk2700NCNPNMFFONGReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.Unk2700_KLJLJGJOBDI), global::Weedwacker.Shared.Network.Proto.Unk2700_KLJLJGJOBDI.Parser, new[]{ "Unk2700CDDONJJMFCI", "Reason", "FinalScore", "Unk2700FFCCLGIFGIP" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Unk2700_KLJLJGJOBDI : pb::IMessage<Unk2700_KLJLJGJOBDI>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Unk2700_KLJLJGJOBDI> _parser = new pb::MessageParser<Unk2700_KLJLJGJOBDI>(() => new Unk2700_KLJLJGJOBDI());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Unk2700_KLJLJGJOBDI> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.Unk2700KLJLJGJOBDIReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_KLJLJGJOBDI() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_KLJLJGJOBDI(Unk2700_KLJLJGJOBDI other) : this() {
      unk2700CDDONJJMFCI_ = other.unk2700CDDONJJMFCI_;
      reason_ = other.reason_;
      finalScore_ = other.finalScore_;
      unk2700FFCCLGIFGIP_ = other.unk2700FFCCLGIFGIP_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_KLJLJGJOBDI Clone() {
      return new Unk2700_KLJLJGJOBDI(this);
    }

    /// <summary>Field number for the "Unk2700_CDDONJJMFCI" field.</summary>
    public const int Unk2700CDDONJJMFCIFieldNumber = 8;
    private uint unk2700CDDONJJMFCI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk2700CDDONJJMFCI {
      get { return unk2700CDDONJJMFCI_; }
      set {
        unk2700CDDONJJMFCI_ = value;
      }
    }

    /// <summary>Field number for the "reason" field.</summary>
    public const int ReasonFieldNumber = 7;
    private global::Weedwacker.Shared.Network.Proto.Unk2700_NCNPNMFFONG reason_ = global::Weedwacker.Shared.Network.Proto.Unk2700_NCNPNMFFONG.Unk2700Eoolpoeeaph;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Unk2700_NCNPNMFFONG Reason {
      get { return reason_; }
      set {
        reason_ = value;
      }
    }

    /// <summary>Field number for the "final_score" field.</summary>
    public const int FinalScoreFieldNumber = 13;
    private uint finalScore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FinalScore {
      get { return finalScore_; }
      set {
        finalScore_ = value;
      }
    }

    /// <summary>Field number for the "Unk2700_FFCCLGIFGIP" field.</summary>
    public const int Unk2700FFCCLGIFGIPFieldNumber = 15;
    private uint unk2700FFCCLGIFGIP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk2700FFCCLGIFGIP {
      get { return unk2700FFCCLGIFGIP_; }
      set {
        unk2700FFCCLGIFGIP_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Unk2700_KLJLJGJOBDI);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Unk2700_KLJLJGJOBDI other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Unk2700CDDONJJMFCI != other.Unk2700CDDONJJMFCI) return false;
      if (Reason != other.Reason) return false;
      if (FinalScore != other.FinalScore) return false;
      if (Unk2700FFCCLGIFGIP != other.Unk2700FFCCLGIFGIP) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Unk2700CDDONJJMFCI != 0) hash ^= Unk2700CDDONJJMFCI.GetHashCode();
      if (Reason != global::Weedwacker.Shared.Network.Proto.Unk2700_NCNPNMFFONG.Unk2700Eoolpoeeaph) hash ^= Reason.GetHashCode();
      if (FinalScore != 0) hash ^= FinalScore.GetHashCode();
      if (Unk2700FFCCLGIFGIP != 0) hash ^= Unk2700FFCCLGIFGIP.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Reason != global::Weedwacker.Shared.Network.Proto.Unk2700_NCNPNMFFONG.Unk2700Eoolpoeeaph) {
        output.WriteRawTag(56);
        output.WriteEnum((int) Reason);
      }
      if (Unk2700CDDONJJMFCI != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Unk2700CDDONJJMFCI);
      }
      if (FinalScore != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(FinalScore);
      }
      if (Unk2700FFCCLGIFGIP != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Unk2700FFCCLGIFGIP);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Reason != global::Weedwacker.Shared.Network.Proto.Unk2700_NCNPNMFFONG.Unk2700Eoolpoeeaph) {
        output.WriteRawTag(56);
        output.WriteEnum((int) Reason);
      }
      if (Unk2700CDDONJJMFCI != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Unk2700CDDONJJMFCI);
      }
      if (FinalScore != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(FinalScore);
      }
      if (Unk2700FFCCLGIFGIP != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Unk2700FFCCLGIFGIP);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Unk2700CDDONJJMFCI != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk2700CDDONJJMFCI);
      }
      if (Reason != global::Weedwacker.Shared.Network.Proto.Unk2700_NCNPNMFFONG.Unk2700Eoolpoeeaph) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Reason);
      }
      if (FinalScore != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FinalScore);
      }
      if (Unk2700FFCCLGIFGIP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk2700FFCCLGIFGIP);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Unk2700_KLJLJGJOBDI other) {
      if (other == null) {
        return;
      }
      if (other.Unk2700CDDONJJMFCI != 0) {
        Unk2700CDDONJJMFCI = other.Unk2700CDDONJJMFCI;
      }
      if (other.Reason != global::Weedwacker.Shared.Network.Proto.Unk2700_NCNPNMFFONG.Unk2700Eoolpoeeaph) {
        Reason = other.Reason;
      }
      if (other.FinalScore != 0) {
        FinalScore = other.FinalScore;
      }
      if (other.Unk2700FFCCLGIFGIP != 0) {
        Unk2700FFCCLGIFGIP = other.Unk2700FFCCLGIFGIP;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 56: {
            Reason = (global::Weedwacker.Shared.Network.Proto.Unk2700_NCNPNMFFONG) input.ReadEnum();
            break;
          }
          case 64: {
            Unk2700CDDONJJMFCI = input.ReadUInt32();
            break;
          }
          case 104: {
            FinalScore = input.ReadUInt32();
            break;
          }
          case 120: {
            Unk2700FFCCLGIFGIP = input.ReadUInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 56: {
            Reason = (global::Weedwacker.Shared.Network.Proto.Unk2700_NCNPNMFFONG) input.ReadEnum();
            break;
          }
          case 64: {
            Unk2700CDDONJJMFCI = input.ReadUInt32();
            break;
          }
          case 104: {
            FinalScore = input.ReadUInt32();
            break;
          }
          case 120: {
            Unk2700FFCCLGIFGIP = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
