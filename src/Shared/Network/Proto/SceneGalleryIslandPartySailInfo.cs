// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SceneGalleryIslandPartySailInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from SceneGalleryIslandPartySailInfo.proto</summary>
  public static partial class SceneGalleryIslandPartySailInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for SceneGalleryIslandPartySailInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SceneGalleryIslandPartySailInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVTY2VuZUdhbGxlcnlJc2xhbmRQYXJ0eVNhaWxJbmZvLnByb3RvGhlVbmsy",
            "ODAwX0ZNQU9FUEVCS0hCLnByb3RvGhlVbmsyODAwX0lNTERHTElNT0RFLnBy",
            "b3RvIvsBCh9TY2VuZUdhbGxlcnlJc2xhbmRQYXJ0eVNhaWxJbmZvEhsKE1Vu",
            "azI4MDBfSEtIRU5MQ0lGTk4YDiABKA0SGwoTVW5rMjgwMF9OR1BMR0xMRkdP",
            "RxgKIAEoDRIxChNVbmsyODAwX0VOSkdFRkJDTE9MGAEgASgOMhQuVW5rMjgw",
            "MF9GTUFPRVBFQktIQhIbChNVbmsyODAwX0ROREtKT0pDREJJGAsgASgNEgwK",
            "BGNvaW4YDyABKA0SIwoFc3RhZ2UYDCABKA4yFC5VbmsyODAwX0lNTERHTElN",
            "T0RFEhsKE1VuazI4MDBfR01PQ01FRkJHSVAYCCABKA1CIqoCH1dlZWR3YWNr",
            "ZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.Unk2800FMAOEPEBKHBReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.Unk2800IMLDGLIMODEReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.SceneGalleryIslandPartySailInfo), global::Weedwacker.Shared.Network.Proto.SceneGalleryIslandPartySailInfo.Parser, new[]{ "Unk2800HKHENLCIFNN", "Unk2800NGPLGLLFGOG", "Unk2800ENJGEFBCLOL", "Unk2800DNDKJOJCDBI", "Coin", "Stage", "Unk2800GMOCMEFBGIP" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SceneGalleryIslandPartySailInfo : pb::IMessage<SceneGalleryIslandPartySailInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SceneGalleryIslandPartySailInfo> _parser = new pb::MessageParser<SceneGalleryIslandPartySailInfo>(() => new SceneGalleryIslandPartySailInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SceneGalleryIslandPartySailInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.SceneGalleryIslandPartySailInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneGalleryIslandPartySailInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneGalleryIslandPartySailInfo(SceneGalleryIslandPartySailInfo other) : this() {
      unk2800HKHENLCIFNN_ = other.unk2800HKHENLCIFNN_;
      unk2800NGPLGLLFGOG_ = other.unk2800NGPLGLLFGOG_;
      unk2800ENJGEFBCLOL_ = other.unk2800ENJGEFBCLOL_;
      unk2800DNDKJOJCDBI_ = other.unk2800DNDKJOJCDBI_;
      coin_ = other.coin_;
      stage_ = other.stage_;
      unk2800GMOCMEFBGIP_ = other.unk2800GMOCMEFBGIP_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneGalleryIslandPartySailInfo Clone() {
      return new SceneGalleryIslandPartySailInfo(this);
    }

    /// <summary>Field number for the "Unk2800_HKHENLCIFNN" field.</summary>
    public const int Unk2800HKHENLCIFNNFieldNumber = 14;
    private uint unk2800HKHENLCIFNN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk2800HKHENLCIFNN {
      get { return unk2800HKHENLCIFNN_; }
      set {
        unk2800HKHENLCIFNN_ = value;
      }
    }

    /// <summary>Field number for the "Unk2800_NGPLGLLFGOG" field.</summary>
    public const int Unk2800NGPLGLLFGOGFieldNumber = 10;
    private uint unk2800NGPLGLLFGOG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk2800NGPLGLLFGOG {
      get { return unk2800NGPLGLLFGOG_; }
      set {
        unk2800NGPLGLLFGOG_ = value;
      }
    }

    /// <summary>Field number for the "Unk2800_ENJGEFBCLOL" field.</summary>
    public const int Unk2800ENJGEFBCLOLFieldNumber = 1;
    private global::Weedwacker.Shared.Network.Proto.Unk2800_FMAOEPEBKHB unk2800ENJGEFBCLOL_ = global::Weedwacker.Shared.Network.Proto.Unk2800_FMAOEPEBKHB.Unk2800Ibmpphflkeo;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Unk2800_FMAOEPEBKHB Unk2800ENJGEFBCLOL {
      get { return unk2800ENJGEFBCLOL_; }
      set {
        unk2800ENJGEFBCLOL_ = value;
      }
    }

    /// <summary>Field number for the "Unk2800_DNDKJOJCDBI" field.</summary>
    public const int Unk2800DNDKJOJCDBIFieldNumber = 11;
    private uint unk2800DNDKJOJCDBI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk2800DNDKJOJCDBI {
      get { return unk2800DNDKJOJCDBI_; }
      set {
        unk2800DNDKJOJCDBI_ = value;
      }
    }

    /// <summary>Field number for the "coin" field.</summary>
    public const int CoinFieldNumber = 15;
    private uint coin_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Coin {
      get { return coin_; }
      set {
        coin_ = value;
      }
    }

    /// <summary>Field number for the "stage" field.</summary>
    public const int StageFieldNumber = 12;
    private global::Weedwacker.Shared.Network.Proto.Unk2800_IMLDGLIMODE stage_ = global::Weedwacker.Shared.Network.Proto.Unk2800_IMLDGLIMODE.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Unk2800_IMLDGLIMODE Stage {
      get { return stage_; }
      set {
        stage_ = value;
      }
    }

    /// <summary>Field number for the "Unk2800_GMOCMEFBGIP" field.</summary>
    public const int Unk2800GMOCMEFBGIPFieldNumber = 8;
    private uint unk2800GMOCMEFBGIP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk2800GMOCMEFBGIP {
      get { return unk2800GMOCMEFBGIP_; }
      set {
        unk2800GMOCMEFBGIP_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SceneGalleryIslandPartySailInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SceneGalleryIslandPartySailInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Unk2800HKHENLCIFNN != other.Unk2800HKHENLCIFNN) return false;
      if (Unk2800NGPLGLLFGOG != other.Unk2800NGPLGLLFGOG) return false;
      if (Unk2800ENJGEFBCLOL != other.Unk2800ENJGEFBCLOL) return false;
      if (Unk2800DNDKJOJCDBI != other.Unk2800DNDKJOJCDBI) return false;
      if (Coin != other.Coin) return false;
      if (Stage != other.Stage) return false;
      if (Unk2800GMOCMEFBGIP != other.Unk2800GMOCMEFBGIP) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Unk2800HKHENLCIFNN != 0) hash ^= Unk2800HKHENLCIFNN.GetHashCode();
      if (Unk2800NGPLGLLFGOG != 0) hash ^= Unk2800NGPLGLLFGOG.GetHashCode();
      if (Unk2800ENJGEFBCLOL != global::Weedwacker.Shared.Network.Proto.Unk2800_FMAOEPEBKHB.Unk2800Ibmpphflkeo) hash ^= Unk2800ENJGEFBCLOL.GetHashCode();
      if (Unk2800DNDKJOJCDBI != 0) hash ^= Unk2800DNDKJOJCDBI.GetHashCode();
      if (Coin != 0) hash ^= Coin.GetHashCode();
      if (Stage != global::Weedwacker.Shared.Network.Proto.Unk2800_IMLDGLIMODE.None) hash ^= Stage.GetHashCode();
      if (Unk2800GMOCMEFBGIP != 0) hash ^= Unk2800GMOCMEFBGIP.GetHashCode();
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
      if (Unk2800ENJGEFBCLOL != global::Weedwacker.Shared.Network.Proto.Unk2800_FMAOEPEBKHB.Unk2800Ibmpphflkeo) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Unk2800ENJGEFBCLOL);
      }
      if (Unk2800GMOCMEFBGIP != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Unk2800GMOCMEFBGIP);
      }
      if (Unk2800NGPLGLLFGOG != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Unk2800NGPLGLLFGOG);
      }
      if (Unk2800DNDKJOJCDBI != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Unk2800DNDKJOJCDBI);
      }
      if (Stage != global::Weedwacker.Shared.Network.Proto.Unk2800_IMLDGLIMODE.None) {
        output.WriteRawTag(96);
        output.WriteEnum((int) Stage);
      }
      if (Unk2800HKHENLCIFNN != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Unk2800HKHENLCIFNN);
      }
      if (Coin != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Coin);
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
      if (Unk2800ENJGEFBCLOL != global::Weedwacker.Shared.Network.Proto.Unk2800_FMAOEPEBKHB.Unk2800Ibmpphflkeo) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Unk2800ENJGEFBCLOL);
      }
      if (Unk2800GMOCMEFBGIP != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Unk2800GMOCMEFBGIP);
      }
      if (Unk2800NGPLGLLFGOG != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Unk2800NGPLGLLFGOG);
      }
      if (Unk2800DNDKJOJCDBI != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Unk2800DNDKJOJCDBI);
      }
      if (Stage != global::Weedwacker.Shared.Network.Proto.Unk2800_IMLDGLIMODE.None) {
        output.WriteRawTag(96);
        output.WriteEnum((int) Stage);
      }
      if (Unk2800HKHENLCIFNN != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Unk2800HKHENLCIFNN);
      }
      if (Coin != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Coin);
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
      if (Unk2800HKHENLCIFNN != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk2800HKHENLCIFNN);
      }
      if (Unk2800NGPLGLLFGOG != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk2800NGPLGLLFGOG);
      }
      if (Unk2800ENJGEFBCLOL != global::Weedwacker.Shared.Network.Proto.Unk2800_FMAOEPEBKHB.Unk2800Ibmpphflkeo) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Unk2800ENJGEFBCLOL);
      }
      if (Unk2800DNDKJOJCDBI != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk2800DNDKJOJCDBI);
      }
      if (Coin != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Coin);
      }
      if (Stage != global::Weedwacker.Shared.Network.Proto.Unk2800_IMLDGLIMODE.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Stage);
      }
      if (Unk2800GMOCMEFBGIP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk2800GMOCMEFBGIP);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SceneGalleryIslandPartySailInfo other) {
      if (other == null) {
        return;
      }
      if (other.Unk2800HKHENLCIFNN != 0) {
        Unk2800HKHENLCIFNN = other.Unk2800HKHENLCIFNN;
      }
      if (other.Unk2800NGPLGLLFGOG != 0) {
        Unk2800NGPLGLLFGOG = other.Unk2800NGPLGLLFGOG;
      }
      if (other.Unk2800ENJGEFBCLOL != global::Weedwacker.Shared.Network.Proto.Unk2800_FMAOEPEBKHB.Unk2800Ibmpphflkeo) {
        Unk2800ENJGEFBCLOL = other.Unk2800ENJGEFBCLOL;
      }
      if (other.Unk2800DNDKJOJCDBI != 0) {
        Unk2800DNDKJOJCDBI = other.Unk2800DNDKJOJCDBI;
      }
      if (other.Coin != 0) {
        Coin = other.Coin;
      }
      if (other.Stage != global::Weedwacker.Shared.Network.Proto.Unk2800_IMLDGLIMODE.None) {
        Stage = other.Stage;
      }
      if (other.Unk2800GMOCMEFBGIP != 0) {
        Unk2800GMOCMEFBGIP = other.Unk2800GMOCMEFBGIP;
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
          case 8: {
            Unk2800ENJGEFBCLOL = (global::Weedwacker.Shared.Network.Proto.Unk2800_FMAOEPEBKHB) input.ReadEnum();
            break;
          }
          case 64: {
            Unk2800GMOCMEFBGIP = input.ReadUInt32();
            break;
          }
          case 80: {
            Unk2800NGPLGLLFGOG = input.ReadUInt32();
            break;
          }
          case 88: {
            Unk2800DNDKJOJCDBI = input.ReadUInt32();
            break;
          }
          case 96: {
            Stage = (global::Weedwacker.Shared.Network.Proto.Unk2800_IMLDGLIMODE) input.ReadEnum();
            break;
          }
          case 112: {
            Unk2800HKHENLCIFNN = input.ReadUInt32();
            break;
          }
          case 120: {
            Coin = input.ReadUInt32();
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
          case 8: {
            Unk2800ENJGEFBCLOL = (global::Weedwacker.Shared.Network.Proto.Unk2800_FMAOEPEBKHB) input.ReadEnum();
            break;
          }
          case 64: {
            Unk2800GMOCMEFBGIP = input.ReadUInt32();
            break;
          }
          case 80: {
            Unk2800NGPLGLLFGOG = input.ReadUInt32();
            break;
          }
          case 88: {
            Unk2800DNDKJOJCDBI = input.ReadUInt32();
            break;
          }
          case 96: {
            Stage = (global::Weedwacker.Shared.Network.Proto.Unk2800_IMLDGLIMODE) input.ReadEnum();
            break;
          }
          case 112: {
            Unk2800HKHENLCIFNN = input.ReadUInt32();
            break;
          }
          case 120: {
            Coin = input.ReadUInt32();
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
