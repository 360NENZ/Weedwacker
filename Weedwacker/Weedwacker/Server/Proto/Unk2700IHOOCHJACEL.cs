// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Unk2700_IHOOCHJACEL.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from Unk2700_IHOOCHJACEL.proto</summary>
  public static partial class Unk2700IHOOCHJACELReflection {

    #region Descriptor
    /// <summary>File descriptor for Unk2700_IHOOCHJACEL.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Unk2700IHOOCHJACELReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlVbmsyNzAwX0lIT09DSEpBQ0VMLnByb3RvGhlVbmsyNzAwX0JHS01BQUlO",
            "UENPLnByb3RvInEKE1VuazI3MDBfSUhPT0NISkFDRUwSEAoIbGV2ZWxfaWQY",
            "ByABKA0SMQoTVW5rMjcwMF9HTUFFSEtNRElHRxgNIAMoCzIULlVuazI3MDBf",
            "QkdLTUFBSU5QQ08SFQoNZGlmZmljdWx0eV9pZBgKIAEoDUIaqgIXV2VlZHdh",
            "Y2tlci5TZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.Unk2700BGKMAAINPCOReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.Unk2700_IHOOCHJACEL), global::Weedwacker.Server.Proto.Unk2700_IHOOCHJACEL.Parser, new[]{ "LevelId", "Unk2700GMAEHKMDIGG", "DifficultyId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 8325
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// IsAllowClient: true
  /// </summary>
  public sealed partial class Unk2700_IHOOCHJACEL : pb::IMessage<Unk2700_IHOOCHJACEL>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Unk2700_IHOOCHJACEL> _parser = new pb::MessageParser<Unk2700_IHOOCHJACEL>(() => new Unk2700_IHOOCHJACEL());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Unk2700_IHOOCHJACEL> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.Unk2700IHOOCHJACELReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_IHOOCHJACEL() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_IHOOCHJACEL(Unk2700_IHOOCHJACEL other) : this() {
      levelId_ = other.levelId_;
      unk2700GMAEHKMDIGG_ = other.unk2700GMAEHKMDIGG_.Clone();
      difficultyId_ = other.difficultyId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_IHOOCHJACEL Clone() {
      return new Unk2700_IHOOCHJACEL(this);
    }

    /// <summary>Field number for the "level_id" field.</summary>
    public const int LevelIdFieldNumber = 7;
    private uint levelId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LevelId {
      get { return levelId_; }
      set {
        levelId_ = value;
      }
    }

    /// <summary>Field number for the "Unk2700_GMAEHKMDIGG" field.</summary>
    public const int Unk2700GMAEHKMDIGGFieldNumber = 13;
    private static readonly pb::FieldCodec<global::Weedwacker.Server.Proto.Unk2700_BGKMAAINPCO> _repeated_unk2700GMAEHKMDIGG_codec
        = pb::FieldCodec.ForMessage(106, global::Weedwacker.Server.Proto.Unk2700_BGKMAAINPCO.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Server.Proto.Unk2700_BGKMAAINPCO> unk2700GMAEHKMDIGG_ = new pbc::RepeatedField<global::Weedwacker.Server.Proto.Unk2700_BGKMAAINPCO>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Server.Proto.Unk2700_BGKMAAINPCO> Unk2700GMAEHKMDIGG {
      get { return unk2700GMAEHKMDIGG_; }
    }

    /// <summary>Field number for the "difficulty_id" field.</summary>
    public const int DifficultyIdFieldNumber = 10;
    private uint difficultyId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DifficultyId {
      get { return difficultyId_; }
      set {
        difficultyId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Unk2700_IHOOCHJACEL);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Unk2700_IHOOCHJACEL other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (LevelId != other.LevelId) return false;
      if(!unk2700GMAEHKMDIGG_.Equals(other.unk2700GMAEHKMDIGG_)) return false;
      if (DifficultyId != other.DifficultyId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (LevelId != 0) hash ^= LevelId.GetHashCode();
      hash ^= unk2700GMAEHKMDIGG_.GetHashCode();
      if (DifficultyId != 0) hash ^= DifficultyId.GetHashCode();
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
      if (LevelId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(LevelId);
      }
      if (DifficultyId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(DifficultyId);
      }
      unk2700GMAEHKMDIGG_.WriteTo(output, _repeated_unk2700GMAEHKMDIGG_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (LevelId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(LevelId);
      }
      if (DifficultyId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(DifficultyId);
      }
      unk2700GMAEHKMDIGG_.WriteTo(ref output, _repeated_unk2700GMAEHKMDIGG_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (LevelId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LevelId);
      }
      size += unk2700GMAEHKMDIGG_.CalculateSize(_repeated_unk2700GMAEHKMDIGG_codec);
      if (DifficultyId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DifficultyId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Unk2700_IHOOCHJACEL other) {
      if (other == null) {
        return;
      }
      if (other.LevelId != 0) {
        LevelId = other.LevelId;
      }
      unk2700GMAEHKMDIGG_.Add(other.unk2700GMAEHKMDIGG_);
      if (other.DifficultyId != 0) {
        DifficultyId = other.DifficultyId;
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
            LevelId = input.ReadUInt32();
            break;
          }
          case 80: {
            DifficultyId = input.ReadUInt32();
            break;
          }
          case 106: {
            unk2700GMAEHKMDIGG_.AddEntriesFrom(input, _repeated_unk2700GMAEHKMDIGG_codec);
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
            LevelId = input.ReadUInt32();
            break;
          }
          case 80: {
            DifficultyId = input.ReadUInt32();
            break;
          }
          case 106: {
            unk2700GMAEHKMDIGG_.AddEntriesFrom(ref input, _repeated_unk2700GMAEHKMDIGG_codec);
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