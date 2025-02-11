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

  public partial class ID : TBase
  {
    private int _space_id;
    private int _tag_id;
    private int _edge_type;
    private int _index_id;
    private long _cluster_id;

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

    public int Tag_id
    {
      get
      {
        return _tag_id;
      }
      set
      {
        __isset.tag_id = true;
        this._tag_id = value;
      }
    }

    public int Edge_type
    {
      get
      {
        return _edge_type;
      }
      set
      {
        __isset.edge_type = true;
        this._edge_type = value;
      }
    }

    public int Index_id
    {
      get
      {
        return _index_id;
      }
      set
      {
        __isset.index_id = true;
        this._index_id = value;
      }
    }

    public long Cluster_id
    {
      get
      {
        return _cluster_id;
      }
      set
      {
        __isset.cluster_id = true;
        this._cluster_id = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool space_id;
      public bool tag_id;
      public bool edge_type;
      public bool index_id;
      public bool cluster_id;
    }

    public ID()
    {
    }

    public ID DeepCopy()
    {
      var tmp0 = new ID();
      if(__isset.space_id)
      {
        tmp0.Space_id = this.Space_id;
      }
      tmp0.__isset.space_id = this.__isset.space_id;
      if(__isset.tag_id)
      {
        tmp0.Tag_id = this.Tag_id;
      }
      tmp0.__isset.tag_id = this.__isset.tag_id;
      if(__isset.edge_type)
      {
        tmp0.Edge_type = this.Edge_type;
      }
      tmp0.__isset.edge_type = this.__isset.edge_type;
      if(__isset.index_id)
      {
        tmp0.Index_id = this.Index_id;
      }
      tmp0.__isset.index_id = this.__isset.index_id;
      if(__isset.cluster_id)
      {
        tmp0.Cluster_id = this.Cluster_id;
      }
      tmp0.__isset.cluster_id = this.__isset.cluster_id;
      return tmp0;
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
              if (field.Type == TType.I32)
              {
                Tag_id = await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.I32)
              {
                Edge_type = await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 4:
              if (field.Type == TType.I32)
              {
                Index_id = await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 5:
              if (field.Type == TType.I64)
              {
                Cluster_id = await iprot.ReadI64Async(cancellationToken);
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
        var tmp1 = new TStruct("ID");
        await oprot.WriteStructBeginAsync(tmp1, cancellationToken);
        var tmp2 = new TField();
        if(__isset.space_id)
        {
          tmp2.Name = "space_id";
          tmp2.Type = TType.I32;
          tmp2.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp2, cancellationToken);
          await oprot.WriteI32Async(Space_id, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.tag_id)
        {
          tmp2.Name = "tag_id";
          tmp2.Type = TType.I32;
          tmp2.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp2, cancellationToken);
          await oprot.WriteI32Async(Tag_id, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.edge_type)
        {
          tmp2.Name = "edge_type";
          tmp2.Type = TType.I32;
          tmp2.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp2, cancellationToken);
          await oprot.WriteI32Async(Edge_type, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.index_id)
        {
          tmp2.Name = "index_id";
          tmp2.Type = TType.I32;
          tmp2.ID = 4;
          await oprot.WriteFieldBeginAsync(tmp2, cancellationToken);
          await oprot.WriteI32Async(Index_id, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.cluster_id)
        {
          tmp2.Name = "cluster_id";
          tmp2.Type = TType.I64;
          tmp2.ID = 5;
          await oprot.WriteFieldBeginAsync(tmp2, cancellationToken);
          await oprot.WriteI64Async(Cluster_id, cancellationToken);
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
      if (!(that is ID other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.space_id == other.__isset.space_id) && ((!__isset.space_id) || (System.Object.Equals(Space_id, other.Space_id))))
        && ((__isset.tag_id == other.__isset.tag_id) && ((!__isset.tag_id) || (System.Object.Equals(Tag_id, other.Tag_id))))
        && ((__isset.edge_type == other.__isset.edge_type) && ((!__isset.edge_type) || (System.Object.Equals(Edge_type, other.Edge_type))))
        && ((__isset.index_id == other.__isset.index_id) && ((!__isset.index_id) || (System.Object.Equals(Index_id, other.Index_id))))
        && ((__isset.cluster_id == other.__isset.cluster_id) && ((!__isset.cluster_id) || (System.Object.Equals(Cluster_id, other.Cluster_id))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if(__isset.space_id)
        {
          hashcode = (hashcode * 397) + Space_id.GetHashCode();
        }
        if(__isset.tag_id)
        {
          hashcode = (hashcode * 397) + Tag_id.GetHashCode();
        }
        if(__isset.edge_type)
        {
          hashcode = (hashcode * 397) + Edge_type.GetHashCode();
        }
        if(__isset.index_id)
        {
          hashcode = (hashcode * 397) + Index_id.GetHashCode();
        }
        if(__isset.cluster_id)
        {
          hashcode = (hashcode * 397) + Cluster_id.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp3 = new StringBuilder("ID(");
      int tmp4 = 0;
      if(__isset.space_id)
      {
        if(0 < tmp4++) { tmp3.Append(", "); }
        tmp3.Append("Space_id: ");
        Space_id.ToString(tmp3);
      }
      if(__isset.tag_id)
      {
        if(0 < tmp4++) { tmp3.Append(", "); }
        tmp3.Append("Tag_id: ");
        Tag_id.ToString(tmp3);
      }
      if(__isset.edge_type)
      {
        if(0 < tmp4++) { tmp3.Append(", "); }
        tmp3.Append("Edge_type: ");
        Edge_type.ToString(tmp3);
      }
      if(__isset.index_id)
      {
        if(0 < tmp4++) { tmp3.Append(", "); }
        tmp3.Append("Index_id: ");
        Index_id.ToString(tmp3);
      }
      if(__isset.cluster_id)
      {
        if(0 < tmp4++) { tmp3.Append(", "); }
        tmp3.Append("Cluster_id: ");
        Cluster_id.ToString(tmp3);
      }
      tmp3.Append(')');
      return tmp3.ToString();
    }
  }

}
