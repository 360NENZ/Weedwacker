// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HomeMarkPointSceneData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from HomeMarkPointSceneData.proto</summary>
  public static partial class HomeMarkPointSceneDataReflection {

    #region Descriptor
    /// <summary>File descriptor for HomeMarkPointSceneData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HomeMarkPointSceneDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxIb21lTWFya1BvaW50U2NlbmVEYXRhLnByb3RvGiBIb21lTWFya1BvaW50",
            "RnVybml0dXJlRGF0YS5wcm90bxoMVmVjdG9yLnByb3RvIpYBChZIb21lTWFy",
            "a1BvaW50U2NlbmVEYXRhEjMKDmZ1cm5pdHVyZV9saXN0GAYgAygLMhsuSG9t",
            "ZU1hcmtQb2ludEZ1cm5pdHVyZURhdGESEQoJbW9kdWxlX2lkGAUgASgNEhAK",
            "CHNjZW5lX2lkGAIgASgNEiIKEXRlYXBvdF9zcGlyaXRfcG9zGAQgASgLMgcu",
            "VmVjdG9yQiKqAh9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.HomeMarkPointFurnitureDataReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.HomeMarkPointSceneData), global::Weedwacker.Shared.Network.Proto.HomeMarkPointSceneData.Parser, new[]{ "FurnitureList", "ModuleId", "SceneId", "TeapotSpiritPos" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class HomeMarkPointSceneData : pb::IMessage<HomeMarkPointSceneData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HomeMarkPointSceneData> _parser = new pb::MessageParser<HomeMarkPointSceneData>(() => new HomeMarkPointSceneData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HomeMarkPointSceneData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.HomeMarkPointSceneDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeMarkPointSceneData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeMarkPointSceneData(HomeMarkPointSceneData other) : this() {
      furnitureList_ = other.furnitureList_.Clone();
      moduleId_ = other.moduleId_;
      sceneId_ = other.sceneId_;
      teapotSpiritPos_ = other.teapotSpiritPos_ != null ? other.teapotSpiritPos_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeMarkPointSceneData Clone() {
      return new HomeMarkPointSceneData(this);
    }

    /// <summary>Field number for the "furniture_list" field.</summary>
    public const int FurnitureListFieldNumber = 6;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.HomeMarkPointFurnitureData> _repeated_furnitureList_codec
        = pb::FieldCodec.ForMessage(50, global::Weedwacker.Shared.Network.Proto.HomeMarkPointFurnitureData.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.HomeMarkPointFurnitureData> furnitureList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.HomeMarkPointFurnitureData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.HomeMarkPointFurnitureData> FurnitureList {
      get { return furnitureList_; }
    }

    /// <summary>Field number for the "module_id" field.</summary>
    public const int ModuleIdFieldNumber = 5;
    private uint moduleId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ModuleId {
      get { return moduleId_; }
      set {
        moduleId_ = value;
      }
    }

    /// <summary>Field number for the "scene_id" field.</summary>
    public const int SceneIdFieldNumber = 2;
    private uint sceneId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SceneId {
      get { return sceneId_; }
      set {
        sceneId_ = value;
      }
    }

    /// <summary>Field number for the "teapot_spirit_pos" field.</summary>
    public const int TeapotSpiritPosFieldNumber = 4;
    private global::Weedwacker.Shared.Network.Proto.Vector teapotSpiritPos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Vector TeapotSpiritPos {
      get { return teapotSpiritPos_; }
      set {
        teapotSpiritPos_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HomeMarkPointSceneData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HomeMarkPointSceneData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!furnitureList_.Equals(other.furnitureList_)) return false;
      if (ModuleId != other.ModuleId) return false;
      if (SceneId != other.SceneId) return false;
      if (!object.Equals(TeapotSpiritPos, other.TeapotSpiritPos)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= furnitureList_.GetHashCode();
      if (ModuleId != 0) hash ^= ModuleId.GetHashCode();
      if (SceneId != 0) hash ^= SceneId.GetHashCode();
      if (teapotSpiritPos_ != null) hash ^= TeapotSpiritPos.GetHashCode();
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
      if (SceneId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(SceneId);
      }
      if (teapotSpiritPos_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(TeapotSpiritPos);
      }
      if (ModuleId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(ModuleId);
      }
      furnitureList_.WriteTo(output, _repeated_furnitureList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (SceneId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(SceneId);
      }
      if (teapotSpiritPos_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(TeapotSpiritPos);
      }
      if (ModuleId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(ModuleId);
      }
      furnitureList_.WriteTo(ref output, _repeated_furnitureList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += furnitureList_.CalculateSize(_repeated_furnitureList_codec);
      if (ModuleId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ModuleId);
      }
      if (SceneId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SceneId);
      }
      if (teapotSpiritPos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TeapotSpiritPos);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HomeMarkPointSceneData other) {
      if (other == null) {
        return;
      }
      furnitureList_.Add(other.furnitureList_);
      if (other.ModuleId != 0) {
        ModuleId = other.ModuleId;
      }
      if (other.SceneId != 0) {
        SceneId = other.SceneId;
      }
      if (other.teapotSpiritPos_ != null) {
        if (teapotSpiritPos_ == null) {
          TeapotSpiritPos = new global::Weedwacker.Shared.Network.Proto.Vector();
        }
        TeapotSpiritPos.MergeFrom(other.TeapotSpiritPos);
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
            SceneId = input.ReadUInt32();
            break;
          }
          case 34: {
            if (teapotSpiritPos_ == null) {
              TeapotSpiritPos = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(TeapotSpiritPos);
            break;
          }
          case 40: {
            ModuleId = input.ReadUInt32();
            break;
          }
          case 50: {
            furnitureList_.AddEntriesFrom(input, _repeated_furnitureList_codec);
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
            SceneId = input.ReadUInt32();
            break;
          }
          case 34: {
            if (teapotSpiritPos_ == null) {
              TeapotSpiritPos = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(TeapotSpiritPos);
            break;
          }
          case 40: {
            ModuleId = input.ReadUInt32();
            break;
          }
          case 50: {
            furnitureList_.AddEntriesFrom(ref input, _repeated_furnitureList_codec);
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
