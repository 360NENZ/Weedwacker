// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Unk2700_CMOCCENBOLJ.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from Unk2700_CMOCCENBOLJ.proto</summary>
  public static partial class Unk2700CMOCCENBOLJReflection {

    #region Descriptor
    /// <summary>File descriptor for Unk2700_CMOCCENBOLJ.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Unk2700CMOCCENBOLJReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlVbmsyNzAwX0NNT0NDRU5CT0xKLnByb3RvIngKE1VuazI3MDBfQ01PQ0NF",
            "TkJPTEoSGwoTVW5rMjcwMF9NTU5JTEdMREhIRBgKIAEoCBIbChNVbmsyNzAw",
            "X09MTEtJRk1PUEFHGAUgASgNEhMKC2ZpbmlzaF90aW1lGA8gASgNEhIKCmRp",
            "ZmZpY3VsdHkYDSABKA1CIqoCH1dlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsu",
            "UHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.Unk2700_CMOCCENBOLJ), global::Weedwacker.Shared.Network.Proto.Unk2700_CMOCCENBOLJ.Parser, new[]{ "Unk2700MMNILGLDHHD", "Unk2700OLLKIFMOPAG", "FinishTime", "Difficulty" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Unk2700_CMOCCENBOLJ : pb::IMessage<Unk2700_CMOCCENBOLJ>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Unk2700_CMOCCENBOLJ> _parser = new pb::MessageParser<Unk2700_CMOCCENBOLJ>(() => new Unk2700_CMOCCENBOLJ());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Unk2700_CMOCCENBOLJ> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.Unk2700CMOCCENBOLJReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_CMOCCENBOLJ() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_CMOCCENBOLJ(Unk2700_CMOCCENBOLJ other) : this() {
      unk2700MMNILGLDHHD_ = other.unk2700MMNILGLDHHD_;
      unk2700OLLKIFMOPAG_ = other.unk2700OLLKIFMOPAG_;
      finishTime_ = other.finishTime_;
      difficulty_ = other.difficulty_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_CMOCCENBOLJ Clone() {
      return new Unk2700_CMOCCENBOLJ(this);
    }

    /// <summary>Field number for the "Unk2700_MMNILGLDHHD" field.</summary>
    public const int Unk2700MMNILGLDHHDFieldNumber = 10;
    private bool unk2700MMNILGLDHHD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk2700MMNILGLDHHD {
      get { return unk2700MMNILGLDHHD_; }
      set {
        unk2700MMNILGLDHHD_ = value;
      }
    }

    /// <summary>Field number for the "Unk2700_OLLKIFMOPAG" field.</summary>
    public const int Unk2700OLLKIFMOPAGFieldNumber = 5;
    private uint unk2700OLLKIFMOPAG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk2700OLLKIFMOPAG {
      get { return unk2700OLLKIFMOPAG_; }
      set {
        unk2700OLLKIFMOPAG_ = value;
      }
    }

    /// <summary>Field number for the "finish_time" field.</summary>
    public const int FinishTimeFieldNumber = 15;
    private uint finishTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FinishTime {
      get { return finishTime_; }
      set {
        finishTime_ = value;
      }
    }

    /// <summary>Field number for the "difficulty" field.</summary>
    public const int DifficultyFieldNumber = 13;
    private uint difficulty_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Difficulty {
      get { return difficulty_; }
      set {
        difficulty_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Unk2700_CMOCCENBOLJ);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Unk2700_CMOCCENBOLJ other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Unk2700MMNILGLDHHD != other.Unk2700MMNILGLDHHD) return false;
      if (Unk2700OLLKIFMOPAG != other.Unk2700OLLKIFMOPAG) return false;
      if (FinishTime != other.FinishTime) return false;
      if (Difficulty != other.Difficulty) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Unk2700MMNILGLDHHD != false) hash ^= Unk2700MMNILGLDHHD.GetHashCode();
      if (Unk2700OLLKIFMOPAG != 0) hash ^= Unk2700OLLKIFMOPAG.GetHashCode();
      if (FinishTime != 0) hash ^= FinishTime.GetHashCode();
      if (Difficulty != 0) hash ^= Difficulty.GetHashCode();
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
      if (Unk2700OLLKIFMOPAG != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Unk2700OLLKIFMOPAG);
      }
      if (Unk2700MMNILGLDHHD != false) {
        output.WriteRawTag(80);
        output.WriteBool(Unk2700MMNILGLDHHD);
      }
      if (Difficulty != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Difficulty);
      }
      if (FinishTime != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(FinishTime);
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
      if (Unk2700OLLKIFMOPAG != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Unk2700OLLKIFMOPAG);
      }
      if (Unk2700MMNILGLDHHD != false) {
        output.WriteRawTag(80);
        output.WriteBool(Unk2700MMNILGLDHHD);
      }
      if (Difficulty != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Difficulty);
      }
      if (FinishTime != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(FinishTime);
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
      if (Unk2700MMNILGLDHHD != false) {
        size += 1 + 1;
      }
      if (Unk2700OLLKIFMOPAG != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk2700OLLKIFMOPAG);
      }
      if (FinishTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FinishTime);
      }
      if (Difficulty != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Difficulty);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Unk2700_CMOCCENBOLJ other) {
      if (other == null) {
        return;
      }
      if (other.Unk2700MMNILGLDHHD != false) {
        Unk2700MMNILGLDHHD = other.Unk2700MMNILGLDHHD;
      }
      if (other.Unk2700OLLKIFMOPAG != 0) {
        Unk2700OLLKIFMOPAG = other.Unk2700OLLKIFMOPAG;
      }
      if (other.FinishTime != 0) {
        FinishTime = other.FinishTime;
      }
      if (other.Difficulty != 0) {
        Difficulty = other.Difficulty;
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
          case 40: {
            Unk2700OLLKIFMOPAG = input.ReadUInt32();
            break;
          }
          case 80: {
            Unk2700MMNILGLDHHD = input.ReadBool();
            break;
          }
          case 104: {
            Difficulty = input.ReadUInt32();
            break;
          }
          case 120: {
            FinishTime = input.ReadUInt32();
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
          case 40: {
            Unk2700OLLKIFMOPAG = input.ReadUInt32();
            break;
          }
          case 80: {
            Unk2700MMNILGLDHHD = input.ReadBool();
            break;
          }
          case 104: {
            Difficulty = input.ReadUInt32();
            break;
          }
          case 120: {
            FinishTime = input.ReadUInt32();
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
