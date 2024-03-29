// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BalloonPlayerInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from BalloonPlayerInfo.proto</summary>
  public static partial class BalloonPlayerInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for BalloonPlayerInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BalloonPlayerInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdCYWxsb29uUGxheWVySW5mby5wcm90byJeChFCYWxsb29uUGxheWVySW5m",
            "bxILCgN1aWQYDyABKA0SEQoJY3VyX3Njb3JlGAIgASgNEhoKEmNvbWJvX2Rp",
            "c2FibGVfdGltZRgOIAEoDRINCgVjb21ibxgLIAEoDUIiqgIfV2VlZHdhY2tl",
            "ci5TaGFyZWQuTmV0d29yay5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.BalloonPlayerInfo), global::Weedwacker.Shared.Network.Proto.BalloonPlayerInfo.Parser, new[]{ "Uid", "CurScore", "ComboDisableTime", "Combo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class BalloonPlayerInfo : pb::IMessage<BalloonPlayerInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BalloonPlayerInfo> _parser = new pb::MessageParser<BalloonPlayerInfo>(() => new BalloonPlayerInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BalloonPlayerInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.BalloonPlayerInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BalloonPlayerInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BalloonPlayerInfo(BalloonPlayerInfo other) : this() {
      uid_ = other.uid_;
      curScore_ = other.curScore_;
      comboDisableTime_ = other.comboDisableTime_;
      combo_ = other.combo_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BalloonPlayerInfo Clone() {
      return new BalloonPlayerInfo(this);
    }

    /// <summary>Field number for the "uid" field.</summary>
    public const int UidFieldNumber = 15;
    private uint uid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Uid {
      get { return uid_; }
      set {
        uid_ = value;
      }
    }

    /// <summary>Field number for the "cur_score" field.</summary>
    public const int CurScoreFieldNumber = 2;
    private uint curScore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurScore {
      get { return curScore_; }
      set {
        curScore_ = value;
      }
    }

    /// <summary>Field number for the "combo_disable_time" field.</summary>
    public const int ComboDisableTimeFieldNumber = 14;
    private uint comboDisableTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ComboDisableTime {
      get { return comboDisableTime_; }
      set {
        comboDisableTime_ = value;
      }
    }

    /// <summary>Field number for the "combo" field.</summary>
    public const int ComboFieldNumber = 11;
    private uint combo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Combo {
      get { return combo_; }
      set {
        combo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BalloonPlayerInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BalloonPlayerInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Uid != other.Uid) return false;
      if (CurScore != other.CurScore) return false;
      if (ComboDisableTime != other.ComboDisableTime) return false;
      if (Combo != other.Combo) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Uid != 0) hash ^= Uid.GetHashCode();
      if (CurScore != 0) hash ^= CurScore.GetHashCode();
      if (ComboDisableTime != 0) hash ^= ComboDisableTime.GetHashCode();
      if (Combo != 0) hash ^= Combo.GetHashCode();
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
      if (CurScore != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(CurScore);
      }
      if (Combo != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Combo);
      }
      if (ComboDisableTime != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(ComboDisableTime);
      }
      if (Uid != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Uid);
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
      if (CurScore != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(CurScore);
      }
      if (Combo != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Combo);
      }
      if (ComboDisableTime != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(ComboDisableTime);
      }
      if (Uid != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Uid);
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
      if (Uid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Uid);
      }
      if (CurScore != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurScore);
      }
      if (ComboDisableTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ComboDisableTime);
      }
      if (Combo != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Combo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BalloonPlayerInfo other) {
      if (other == null) {
        return;
      }
      if (other.Uid != 0) {
        Uid = other.Uid;
      }
      if (other.CurScore != 0) {
        CurScore = other.CurScore;
      }
      if (other.ComboDisableTime != 0) {
        ComboDisableTime = other.ComboDisableTime;
      }
      if (other.Combo != 0) {
        Combo = other.Combo;
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
          case 16: {
            CurScore = input.ReadUInt32();
            break;
          }
          case 88: {
            Combo = input.ReadUInt32();
            break;
          }
          case 112: {
            ComboDisableTime = input.ReadUInt32();
            break;
          }
          case 120: {
            Uid = input.ReadUInt32();
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
          case 16: {
            CurScore = input.ReadUInt32();
            break;
          }
          case 88: {
            Combo = input.ReadUInt32();
            break;
          }
          case 112: {
            ComboDisableTime = input.ReadUInt32();
            break;
          }
          case 120: {
            Uid = input.ReadUInt32();
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
