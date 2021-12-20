/**
 * Autogenerated by Thrift Compiler (0.15.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Thrift;
using Thrift.Collections;

using Thrift.Protocol;
using Thrift.Protocol.Entities;
using Thrift.Protocol.Utilities;
using Thrift.Transport;
using Thrift.Transport.Client;
using Thrift.Transport.Server;
using Thrift.Processor;


#pragma warning disable IDE0079  // remove unnecessary pragmas
#pragma warning disable IDE1006  // parts of the code use IDL spelling
#pragma warning disable IDE0083  // pattern matching "that is not SomeType" requires net5.0 but we still support earlier versions

namespace Nebula.Meta
{

  public partial class CreateTagIndexReq : TBase
  {
    private int _space_id;
    private byte[] _index_name;
    private byte[] _tag_name;
    private List<global::Nebula.Meta.IndexFieldDef> _fields;
    private bool _if_not_exists;
    private byte[] _comment;

    public int Space_id
    {
      get
      {
        return _space_id;
      }
      set
      {
        __isset.space_id = true;
        this._space_id = value;
      }
    }

    public byte[] Index_name
    {
      get
      {
        return _index_name;
      }
      set
      {
        __isset.index_name = true;
        this._index_name = value;
      }
    }

    public byte[] Tag_name
    {
      get
      {
        return _tag_name;
      }
      set
      {
        __isset.tag_name = true;
        this._tag_name = value;
      }
    }

    public List<global::Nebula.Meta.IndexFieldDef> Fields
    {
      get
      {
        return _fields;
      }
      set
      {
        __isset.fields = true;
        this._fields = value;
      }
    }

    public bool If_not_exists
    {
      get
      {
        return _if_not_exists;
      }
      set
      {
        __isset.if_not_exists = true;
        this._if_not_exists = value;
      }
    }

    public byte[] Comment
    {
      get
      {
        return _comment;
      }
      set
      {
        __isset.comment = true;
        this._comment = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool space_id;
      public bool index_name;
      public bool tag_name;
      public bool fields;
      public bool if_not_exists;
      public bool comment;
    }

    public CreateTagIndexReq()
    {
    }

    public CreateTagIndexReq DeepCopy()
    {
      var tmp468 = new CreateTagIndexReq();
      if(__isset.space_id)
      {
        tmp468.Space_id = this.Space_id;
      }
      tmp468.__isset.space_id = this.__isset.space_id;
      if((Index_name != null) && __isset.index_name)
      {
        tmp468.Index_name = this.Index_name.ToArray();
      }
      tmp468.__isset.index_name = this.__isset.index_name;
      if((Tag_name != null) && __isset.tag_name)
      {
        tmp468.Tag_name = this.Tag_name.ToArray();
      }
      tmp468.__isset.tag_name = this.__isset.tag_name;
      if((Fields != null) && __isset.fields)
      {
        tmp468.Fields = this.Fields.DeepCopy();
      }
      tmp468.__isset.fields = this.__isset.fields;
      if(__isset.if_not_exists)
      {
        tmp468.If_not_exists = this.If_not_exists;
      }
      tmp468.__isset.if_not_exists = this.__isset.if_not_exists;
      if((Comment != null) && __isset.comment)
      {
        tmp468.Comment = this.Comment.ToArray();
      }
      tmp468.__isset.comment = this.__isset.comment;
      return tmp468;
    }

    public async global::System.Threading.Tasks.Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        TField field;
        await iprot.ReadStructBeginAsync(cancellationToken);
        while (true)
        {
          field = await iprot.ReadFieldBeginAsync(cancellationToken);
          if (field.Type == TType.Stop)
          {
            break;
          }

          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.I32)
              {
                Space_id = await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.String)
              {
                Index_name = await iprot.ReadBinaryAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.String)
              {
                Tag_name = await iprot.ReadBinaryAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 4:
              if (field.Type == TType.List)
              {
                {
                  TList _list469 = await iprot.ReadListBeginAsync(cancellationToken);
                  Fields = new List<global::Nebula.Meta.IndexFieldDef>(_list469.Count);
                  for(int _i470 = 0; _i470 < _list469.Count; ++_i470)
                  {
                    global::Nebula.Meta.IndexFieldDef _elem471;
                    _elem471 = new global::Nebula.Meta.IndexFieldDef();
                    await _elem471.ReadAsync(iprot, cancellationToken);
                    Fields.Add(_elem471);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 5:
              if (field.Type == TType.Bool)
              {
                If_not_exists = await iprot.ReadBoolAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 6:
              if (field.Type == TType.String)
              {
                Comment = await iprot.ReadBinaryAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            default: 
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              break;
          }

          await iprot.ReadFieldEndAsync(cancellationToken);
        }

        await iprot.ReadStructEndAsync(cancellationToken);
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public async global::System.Threading.Tasks.Task WriteAsync(TProtocol oprot, CancellationToken cancellationToken)
    {
      oprot.IncrementRecursionDepth();
      try
      {
        var tmp472 = new TStruct("CreateTagIndexReq");
        await oprot.WriteStructBeginAsync(tmp472, cancellationToken);
        var tmp473 = new TField();
        if(__isset.space_id)
        {
          tmp473.Name = "space_id";
          tmp473.Type = TType.I32;
          tmp473.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp473, cancellationToken);
          await oprot.WriteI32Async(Space_id, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Index_name != null) && __isset.index_name)
        {
          tmp473.Name = "index_name";
          tmp473.Type = TType.String;
          tmp473.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp473, cancellationToken);
          await oprot.WriteBinaryAsync(Index_name, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Tag_name != null) && __isset.tag_name)
        {
          tmp473.Name = "tag_name";
          tmp473.Type = TType.String;
          tmp473.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp473, cancellationToken);
          await oprot.WriteBinaryAsync(Tag_name, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Fields != null) && __isset.fields)
        {
          tmp473.Name = "fields";
          tmp473.Type = TType.List;
          tmp473.ID = 4;
          await oprot.WriteFieldBeginAsync(tmp473, cancellationToken);
          {
            await oprot.WriteListBeginAsync(new TList(TType.Struct, Fields.Count), cancellationToken);
            foreach (global::Nebula.Meta.IndexFieldDef _iter474 in Fields)
            {
              await _iter474.WriteAsync(oprot, cancellationToken);
            }
            await oprot.WriteListEndAsync(cancellationToken);
          }
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.if_not_exists)
        {
          tmp473.Name = "if_not_exists";
          tmp473.Type = TType.Bool;
          tmp473.ID = 5;
          await oprot.WriteFieldBeginAsync(tmp473, cancellationToken);
          await oprot.WriteBoolAsync(If_not_exists, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Comment != null) && __isset.comment)
        {
          tmp473.Name = "comment";
          tmp473.Type = TType.String;
          tmp473.ID = 6;
          await oprot.WriteFieldBeginAsync(tmp473, cancellationToken);
          await oprot.WriteBinaryAsync(Comment, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        await oprot.WriteFieldStopAsync(cancellationToken);
        await oprot.WriteStructEndAsync(cancellationToken);
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override bool Equals(object that)
    {
      if (!(that is CreateTagIndexReq other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.space_id == other.__isset.space_id) && ((!__isset.space_id) || (System.Object.Equals(Space_id, other.Space_id))))
        && ((__isset.index_name == other.__isset.index_name) && ((!__isset.index_name) || (TCollections.Equals(Index_name, other.Index_name))))
        && ((__isset.tag_name == other.__isset.tag_name) && ((!__isset.tag_name) || (TCollections.Equals(Tag_name, other.Tag_name))))
        && ((__isset.fields == other.__isset.fields) && ((!__isset.fields) || (TCollections.Equals(Fields, other.Fields))))
        && ((__isset.if_not_exists == other.__isset.if_not_exists) && ((!__isset.if_not_exists) || (System.Object.Equals(If_not_exists, other.If_not_exists))))
        && ((__isset.comment == other.__isset.comment) && ((!__isset.comment) || (TCollections.Equals(Comment, other.Comment))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if(__isset.space_id)
        {
          hashcode = (hashcode * 397) + Space_id.GetHashCode();
        }
        if((Index_name != null) && __isset.index_name)
        {
          hashcode = (hashcode * 397) + Index_name.GetHashCode();
        }
        if((Tag_name != null) && __isset.tag_name)
        {
          hashcode = (hashcode * 397) + Tag_name.GetHashCode();
        }
        if((Fields != null) && __isset.fields)
        {
          hashcode = (hashcode * 397) + TCollections.GetHashCode(Fields);
        }
        if(__isset.if_not_exists)
        {
          hashcode = (hashcode * 397) + If_not_exists.GetHashCode();
        }
        if((Comment != null) && __isset.comment)
        {
          hashcode = (hashcode * 397) + Comment.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp475 = new StringBuilder("CreateTagIndexReq(");
      int tmp476 = 0;
      if(__isset.space_id)
      {
        if(0 < tmp476++) { tmp475.Append(", "); }
        tmp475.Append("Space_id: ");
        Space_id.ToString(tmp475);
      }
      if((Index_name != null) && __isset.index_name)
      {
        if(0 < tmp476++) { tmp475.Append(", "); }
        tmp475.Append("Index_name: ");
        Index_name.ToString(tmp475);
      }
      if((Tag_name != null) && __isset.tag_name)
      {
        if(0 < tmp476++) { tmp475.Append(", "); }
        tmp475.Append("Tag_name: ");
        Tag_name.ToString(tmp475);
      }
      if((Fields != null) && __isset.fields)
      {
        if(0 < tmp476++) { tmp475.Append(", "); }
        tmp475.Append("Fields: ");
        Fields.ToString(tmp475);
      }
      if(__isset.if_not_exists)
      {
        if(0 < tmp476++) { tmp475.Append(", "); }
        tmp475.Append("If_not_exists: ");
        If_not_exists.ToString(tmp475);
      }
      if((Comment != null) && __isset.comment)
      {
        if(0 < tmp476++) { tmp475.Append(", "); }
        tmp475.Append("Comment: ");
        Comment.ToString(tmp475);
      }
      tmp475.Append(')');
      return tmp475.ToString();
    }
  }

}
