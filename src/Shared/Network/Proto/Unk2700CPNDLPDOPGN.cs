// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Unk2700_CPNDLPDOPGN.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from Unk2700_CPNDLPDOPGN.proto</summary>
  public static partial class Unk2700CPNDLPDOPGNReflection {

    #region Descriptor
    /// <summary>File descriptor for Unk2700_CPNDLPDOPGN.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Unk2700CPNDLPDOPGNReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlVbmsyNzAwX0NQTkRMUERPUEdOLnByb3RvInAKE1VuazI3MDBfQ1BORExQ",
            "RE9QR04SGwoTVW5rMjcwMF9PTk9PSkJFQUJPRRgDIAEoBBILCgN1aWQYDyAB",
            "KA0SEQoJdGltZXN0YW1wGAQgASgNEg4KBnJlZ2lvbhgLIAEoCRIMCgRsYW5n",
            "GA0gASgNQiKqAh9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.Unk2700_CPNDLPDOPGN), global::Weedwacker.Shared.Network.Proto.Unk2700_CPNDLPDOPGN.Parser, new[]{ "Unk2700ONOOJBEABOE", "Uid", "Timestamp", "Region", "Lang" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Unk2700_CPNDLPDOPGN : pb::IMessage<Unk2700_CPNDLPDOPGN>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Unk2700_CPNDLPDOPGN> _parser = new pb::MessageParser<Unk2700_CPNDLPDOPGN>(() => new Unk2700_CPNDLPDOPGN());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Unk2700_CPNDLPDOPGN> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.Unk2700CPNDLPDOPGNReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_CPNDLPDOPGN() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_CPNDLPDOPGN(Unk2700_CPNDLPDOPGN other) : this() {
      unk2700ONOOJBEABOE_ = other.unk2700ONOOJBEABOE_;
      uid_ = other.uid_;
      timestamp_ = other.timestamp_;
      region_ = other.region_;
      lang_ = other.lang_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_CPNDLPDOPGN Clone() {
      return new Unk2700_CPNDLPDOPGN(this);
    }

    /// <summary>Field number for the "Unk2700_ONOOJBEABOE" field.</summary>
    public const int Unk2700ONOOJBEABOEFieldNumber = 3;
    private ulong unk2700ONOOJBEABOE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong Unk2700ONOOJBEABOE {
      get { return unk2700ONOOJBEABOE_; }
      set {
        unk2700ONOOJBEABOE_ = value;
      }
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

    /// <summary>Field number for the "timestamp" field.</summary>
    public const int TimestampFieldNumber = 4;
    private uint timestamp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Timestamp {
      get { return timestamp_; }
      set {
        timestamp_ = value;
      }
    }

    /// <summary>Field number for the "region" field.</summary>
    public const int RegionFieldNumber = 11;
    private string region_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Region {
      get { return region_; }
      set {
        region_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "lang" field.</summary>
    public const int LangFieldNumber = 13;
    private uint lang_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Lang {
      get { return lang_; }
      set {
        lang_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Unk2700_CPNDLPDOPGN);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Unk2700_CPNDLPDOPGN other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Unk2700ONOOJBEABOE != other.Unk2700ONOOJBEABOE) return false;
      if (Uid != other.Uid) return false;
      if (Timestamp != other.Timestamp) return false;
      if (Region != other.Region) return false;
      if (Lang != other.Lang) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Unk2700ONOOJBEABOE != 0UL) hash ^= Unk2700ONOOJBEABOE.GetHashCode();
      if (Uid != 0) hash ^= Uid.GetHashCode();
      if (Timestamp != 0) hash ^= Timestamp.GetHashCode();
      if (Region.Length != 0) hash ^= Region.GetHashCode();
      if (Lang != 0) hash ^= Lang.GetHashCode();
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
      if (Unk2700ONOOJBEABOE != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(Unk2700ONOOJBEABOE);
      }
      if (Timestamp != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Timestamp);
      }
      if (Region.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(Region);
      }
      if (Lang != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Lang);
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
      if (Unk2700ONOOJBEABOE != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(Unk2700ONOOJBEABOE);
      }
      if (Timestamp != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Timestamp);
      }
      if (Region.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(Region);
      }
      if (Lang != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Lang);
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
      if (Unk2700ONOOJBEABOE != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Unk2700ONOOJBEABOE);
      }
      if (Uid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Uid);
      }
      if (Timestamp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Timestamp);
      }
      if (Region.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Region);
      }
      if (Lang != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Lang);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Unk2700_CPNDLPDOPGN other) {
      if (other == null) {
        return;
      }
      if (other.Unk2700ONOOJBEABOE != 0UL) {
        Unk2700ONOOJBEABOE = other.Unk2700ONOOJBEABOE;
      }
      if (other.Uid != 0) {
        Uid = other.Uid;
      }
      if (other.Timestamp != 0) {
        Timestamp = other.Timestamp;
      }
      if (other.Region.Length != 0) {
        Region = other.Region;
      }
      if (other.Lang != 0) {
        Lang = other.Lang;
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
          case 24: {
            Unk2700ONOOJBEABOE = input.ReadUInt64();
            break;
          }
          case 32: {
            Timestamp = input.ReadUInt32();
            break;
          }
          case 90: {
            Region = input.ReadString();
            break;
          }
          case 104: {
            Lang = input.ReadUInt32();
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
          case 24: {
            Unk2700ONOOJBEABOE = input.ReadUInt64();
            break;
          }
          case 32: {
            Timestamp = input.ReadUInt32();
            break;
          }
          case 90: {
            Region = input.ReadString();
            break;
          }
          case 104: {
            Lang = input.ReadUInt32();
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
