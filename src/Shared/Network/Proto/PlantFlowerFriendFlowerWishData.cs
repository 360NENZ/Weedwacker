// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlantFlowerFriendFlowerWishData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from PlantFlowerFriendFlowerWishData.proto</summary>
  public static partial class PlantFlowerFriendFlowerWishDataReflection {

    #region Descriptor
    /// <summary>File descriptor for PlantFlowerFriendFlowerWishData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlantFlowerFriendFlowerWishDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVQbGFudEZsb3dlckZyaWVuZEZsb3dlcldpc2hEYXRhLnByb3RvGhRQcm9m",
            "aWxlUGljdHVyZS5wcm90byLrAQofUGxhbnRGbG93ZXJGcmllbmRGbG93ZXJX",
            "aXNoRGF0YRIoCg9wcm9maWxlX3BpY3R1cmUYAyABKAsyDy5Qcm9maWxlUGlj",
            "dHVyZRILCgN1aWQYBSABKA0SEAoIbmlja25hbWUYDiABKAkSSgoOZmxvd2Vy",
            "X251bV9tYXAYDCADKAsyMi5QbGFudEZsb3dlckZyaWVuZEZsb3dlcldpc2hE",
            "YXRhLkZsb3dlck51bU1hcEVudHJ5GjMKEUZsb3dlck51bU1hcEVudHJ5EgsK",
            "A2tleRgBIAEoDRINCgV2YWx1ZRgCIAEoDToCOAFCIqoCH1dlZWR3YWNrZXIu",
            "U2hhcmVkLk5ldHdvcmsuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.ProfilePictureReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.PlantFlowerFriendFlowerWishData), global::Weedwacker.Shared.Network.Proto.PlantFlowerFriendFlowerWishData.Parser, new[]{ "ProfilePicture", "Uid", "Nickname", "FlowerNumMap" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PlantFlowerFriendFlowerWishData : pb::IMessage<PlantFlowerFriendFlowerWishData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlantFlowerFriendFlowerWishData> _parser = new pb::MessageParser<PlantFlowerFriendFlowerWishData>(() => new PlantFlowerFriendFlowerWishData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlantFlowerFriendFlowerWishData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.PlantFlowerFriendFlowerWishDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlantFlowerFriendFlowerWishData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlantFlowerFriendFlowerWishData(PlantFlowerFriendFlowerWishData other) : this() {
      profilePicture_ = other.profilePicture_ != null ? other.profilePicture_.Clone() : null;
      uid_ = other.uid_;
      nickname_ = other.nickname_;
      flowerNumMap_ = other.flowerNumMap_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlantFlowerFriendFlowerWishData Clone() {
      return new PlantFlowerFriendFlowerWishData(this);
    }

    /// <summary>Field number for the "profile_picture" field.</summary>
    public const int ProfilePictureFieldNumber = 3;
    private global::Weedwacker.Shared.Network.Proto.ProfilePicture profilePicture_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.ProfilePicture ProfilePicture {
      get { return profilePicture_; }
      set {
        profilePicture_ = value;
      }
    }

    /// <summary>Field number for the "uid" field.</summary>
    public const int UidFieldNumber = 5;
    private uint uid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Uid {
      get { return uid_; }
      set {
        uid_ = value;
      }
    }

    /// <summary>Field number for the "nickname" field.</summary>
    public const int NicknameFieldNumber = 14;
    private string nickname_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Nickname {
      get { return nickname_; }
      set {
        nickname_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "flower_num_map" field.</summary>
    public const int FlowerNumMapFieldNumber = 12;
    private static readonly pbc::MapField<uint, uint>.Codec _map_flowerNumMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 98);
    private readonly pbc::MapField<uint, uint> flowerNumMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> FlowerNumMap {
      get { return flowerNumMap_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlantFlowerFriendFlowerWishData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlantFlowerFriendFlowerWishData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ProfilePicture, other.ProfilePicture)) return false;
      if (Uid != other.Uid) return false;
      if (Nickname != other.Nickname) return false;
      if (!FlowerNumMap.Equals(other.FlowerNumMap)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (profilePicture_ != null) hash ^= ProfilePicture.GetHashCode();
      if (Uid != 0) hash ^= Uid.GetHashCode();
      if (Nickname.Length != 0) hash ^= Nickname.GetHashCode();
      hash ^= FlowerNumMap.GetHashCode();
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
      if (profilePicture_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(ProfilePicture);
      }
      if (Uid != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Uid);
      }
      flowerNumMap_.WriteTo(output, _map_flowerNumMap_codec);
      if (Nickname.Length != 0) {
        output.WriteRawTag(114);
        output.WriteString(Nickname);
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
      if (profilePicture_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(ProfilePicture);
      }
      if (Uid != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Uid);
      }
      flowerNumMap_.WriteTo(ref output, _map_flowerNumMap_codec);
      if (Nickname.Length != 0) {
        output.WriteRawTag(114);
        output.WriteString(Nickname);
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
      if (profilePicture_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ProfilePicture);
      }
      if (Uid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Uid);
      }
      if (Nickname.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Nickname);
      }
      size += flowerNumMap_.CalculateSize(_map_flowerNumMap_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlantFlowerFriendFlowerWishData other) {
      if (other == null) {
        return;
      }
      if (other.profilePicture_ != null) {
        if (profilePicture_ == null) {
          ProfilePicture = new global::Weedwacker.Shared.Network.Proto.ProfilePicture();
        }
        ProfilePicture.MergeFrom(other.ProfilePicture);
      }
      if (other.Uid != 0) {
        Uid = other.Uid;
      }
      if (other.Nickname.Length != 0) {
        Nickname = other.Nickname;
      }
      flowerNumMap_.Add(other.flowerNumMap_);
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
          case 26: {
            if (profilePicture_ == null) {
              ProfilePicture = new global::Weedwacker.Shared.Network.Proto.ProfilePicture();
            }
            input.ReadMessage(ProfilePicture);
            break;
          }
          case 40: {
            Uid = input.ReadUInt32();
            break;
          }
          case 98: {
            flowerNumMap_.AddEntriesFrom(input, _map_flowerNumMap_codec);
            break;
          }
          case 114: {
            Nickname = input.ReadString();
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
          case 26: {
            if (profilePicture_ == null) {
              ProfilePicture = new global::Weedwacker.Shared.Network.Proto.ProfilePicture();
            }
            input.ReadMessage(ProfilePicture);
            break;
          }
          case 40: {
            Uid = input.ReadUInt32();
            break;
          }
          case 98: {
            flowerNumMap_.AddEntriesFrom(ref input, _map_flowerNumMap_codec);
            break;
          }
          case 114: {
            Nickname = input.ReadString();
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
