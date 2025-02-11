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

namespace Nebula.Storage
{
  public partial class InternalStorageService
  {
    public interface IAsync
    {
      global::System.Threading.Tasks.Task<global::Nebula.Storage.ExecResponse> chainAddEdges(global::Nebula.Storage.ChainAddEdgesRequest req, CancellationToken cancellationToken = default);

      global::System.Threading.Tasks.Task<global::Nebula.Storage.UpdateResponse> chainUpdateEdge(global::Nebula.Storage.ChainUpdateEdgeRequest req, CancellationToken cancellationToken = default);

    }


    public class Client : TBaseClient, IDisposable, IAsync
    {
      public Client(TProtocol protocol) : this(protocol, protocol)
      {
      }

      public Client(TProtocol inputProtocol, TProtocol outputProtocol) : base(inputProtocol, outputProtocol)
      {
      }

      public async global::System.Threading.Tasks.Task<global::Nebula.Storage.ExecResponse> chainAddEdges(global::Nebula.Storage.ChainAddEdgesRequest req, CancellationToken cancellationToken = default)
      {
        await send_chainAddEdges(req, cancellationToken);
        return await recv_chainAddEdges(cancellationToken);
      }

      public async global::System.Threading.Tasks.Task send_chainAddEdges(global::Nebula.Storage.ChainAddEdgesRequest req, CancellationToken cancellationToken = default)
      {
        await OutputProtocol.WriteMessageBeginAsync(new TMessage("chainAddEdges", TMessageType.Call, SeqId), cancellationToken);
        
        var tmp1283 = new InternalStructs.chainAddEdges_args() {
          Req = req,
        };
        
        await tmp1283.WriteAsync(OutputProtocol, cancellationToken);
        await OutputProtocol.WriteMessageEndAsync(cancellationToken);
        await OutputProtocol.Transport.FlushAsync(cancellationToken);
      }

      public async global::System.Threading.Tasks.Task<global::Nebula.Storage.ExecResponse> recv_chainAddEdges(CancellationToken cancellationToken = default)
      {
        
        var tmp1284 = await InputProtocol.ReadMessageBeginAsync(cancellationToken);
        if (tmp1284.Type == TMessageType.Exception)
        {
          var tmp1285 = await TApplicationException.ReadAsync(InputProtocol, cancellationToken);
          await InputProtocol.ReadMessageEndAsync(cancellationToken);
          throw tmp1285;
        }

        var tmp1286 = new InternalStructs.chainAddEdges_result();
        await tmp1286.ReadAsync(InputProtocol, cancellationToken);
        await InputProtocol.ReadMessageEndAsync(cancellationToken);
        if (tmp1286.__isset.success)
        {
          return tmp1286.Success;
        }
        throw new TApplicationException(TApplicationException.ExceptionType.MissingResult, "chainAddEdges failed: unknown result");
      }

      public async global::System.Threading.Tasks.Task<global::Nebula.Storage.UpdateResponse> chainUpdateEdge(global::Nebula.Storage.ChainUpdateEdgeRequest req, CancellationToken cancellationToken = default)
      {
        await send_chainUpdateEdge(req, cancellationToken);
        return await recv_chainUpdateEdge(cancellationToken);
      }

      public async global::System.Threading.Tasks.Task send_chainUpdateEdge(global::Nebula.Storage.ChainUpdateEdgeRequest req, CancellationToken cancellationToken = default)
      {
        await OutputProtocol.WriteMessageBeginAsync(new TMessage("chainUpdateEdge", TMessageType.Call, SeqId), cancellationToken);
        
        var tmp1287 = new InternalStructs.chainUpdateEdge_args() {
          Req = req,
        };
        
        await tmp1287.WriteAsync(OutputProtocol, cancellationToken);
        await OutputProtocol.WriteMessageEndAsync(cancellationToken);
        await OutputProtocol.Transport.FlushAsync(cancellationToken);
      }

      public async global::System.Threading.Tasks.Task<global::Nebula.Storage.UpdateResponse> recv_chainUpdateEdge(CancellationToken cancellationToken = default)
      {
        
        var tmp1288 = await InputProtocol.ReadMessageBeginAsync(cancellationToken);
        if (tmp1288.Type == TMessageType.Exception)
        {
          var tmp1289 = await TApplicationException.ReadAsync(InputProtocol, cancellationToken);
          await InputProtocol.ReadMessageEndAsync(cancellationToken);
          throw tmp1289;
        }

        var tmp1290 = new InternalStructs.chainUpdateEdge_result();
        await tmp1290.ReadAsync(InputProtocol, cancellationToken);
        await InputProtocol.ReadMessageEndAsync(cancellationToken);
        if (tmp1290.__isset.success)
        {
          return tmp1290.Success;
        }
        throw new TApplicationException(TApplicationException.ExceptionType.MissingResult, "chainUpdateEdge failed: unknown result");
      }

    }

    public class AsyncProcessor : ITAsyncProcessor
    {
      private readonly IAsync _iAsync;
      private readonly ILogger<AsyncProcessor> _logger;

      public AsyncProcessor(IAsync iAsync, ILogger<AsyncProcessor> logger = default)
      {
        _iAsync = iAsync ?? throw new ArgumentNullException(nameof(iAsync));
        _logger = logger;
        processMap_["chainAddEdges"] = chainAddEdges_ProcessAsync;
        processMap_["chainUpdateEdge"] = chainUpdateEdge_ProcessAsync;
      }

      protected delegate global::System.Threading.Tasks.Task ProcessFunction(int seqid, TProtocol iprot, TProtocol oprot, CancellationToken cancellationToken);
      protected Dictionary<string, ProcessFunction> processMap_ = new Dictionary<string, ProcessFunction>();

      public async Task<bool> ProcessAsync(TProtocol iprot, TProtocol oprot)
      {
        return await ProcessAsync(iprot, oprot, CancellationToken.None);
      }

      public async Task<bool> ProcessAsync(TProtocol iprot, TProtocol oprot, CancellationToken cancellationToken)
      {
        try
        {
          var msg = await iprot.ReadMessageBeginAsync(cancellationToken);

          processMap_.TryGetValue(msg.Name, out ProcessFunction fn);

          if (fn == null)
          {
            await TProtocolUtil.SkipAsync(iprot, TType.Struct, cancellationToken);
            await iprot.ReadMessageEndAsync(cancellationToken);
            var x = new TApplicationException (TApplicationException.ExceptionType.UnknownMethod, "Invalid method name: '" + msg.Name + "'");
            await oprot.WriteMessageBeginAsync(new TMessage(msg.Name, TMessageType.Exception, msg.SeqID), cancellationToken);
            await x.WriteAsync(oprot, cancellationToken);
            await oprot.WriteMessageEndAsync(cancellationToken);
            await oprot.Transport.FlushAsync(cancellationToken);
            return true;
          }

          await fn(msg.SeqID, iprot, oprot, cancellationToken);

        }
        catch (IOException)
        {
          return false;
        }

        return true;
      }

      public async global::System.Threading.Tasks.Task chainAddEdges_ProcessAsync(int seqid, TProtocol iprot, TProtocol oprot, CancellationToken cancellationToken)
      {
        var tmp1291 = new InternalStructs.chainAddEdges_args();
        await tmp1291.ReadAsync(iprot, cancellationToken);
        await iprot.ReadMessageEndAsync(cancellationToken);
        var tmp1292 = new InternalStructs.chainAddEdges_result();
        try
        {
          tmp1292.Success = await _iAsync.chainAddEdges(tmp1291.Req, cancellationToken);
          await oprot.WriteMessageBeginAsync(new TMessage("chainAddEdges", TMessageType.Reply, seqid), cancellationToken); 
          await tmp1292.WriteAsync(oprot, cancellationToken);
        }
        catch (TTransportException)
        {
          throw;
        }
        catch (Exception tmp1293)
        {
          var tmp1294 = $"Error occurred in {GetType().FullName}: {tmp1293.Message}";
          if(_logger != null)
            _logger.LogError(tmp1293, tmp1294);
          else
            Console.Error.WriteLine(tmp1294);
          var tmp1295 = new TApplicationException(TApplicationException.ExceptionType.InternalError," Internal error.");
          await oprot.WriteMessageBeginAsync(new TMessage("chainAddEdges", TMessageType.Exception, seqid), cancellationToken);
          await tmp1295.WriteAsync(oprot, cancellationToken);
        }
        await oprot.WriteMessageEndAsync(cancellationToken);
        await oprot.Transport.FlushAsync(cancellationToken);
      }

      public async global::System.Threading.Tasks.Task chainUpdateEdge_ProcessAsync(int seqid, TProtocol iprot, TProtocol oprot, CancellationToken cancellationToken)
      {
        var tmp1296 = new InternalStructs.chainUpdateEdge_args();
        await tmp1296.ReadAsync(iprot, cancellationToken);
        await iprot.ReadMessageEndAsync(cancellationToken);
        var tmp1297 = new InternalStructs.chainUpdateEdge_result();
        try
        {
          tmp1297.Success = await _iAsync.chainUpdateEdge(tmp1296.Req, cancellationToken);
          await oprot.WriteMessageBeginAsync(new TMessage("chainUpdateEdge", TMessageType.Reply, seqid), cancellationToken); 
          await tmp1297.WriteAsync(oprot, cancellationToken);
        }
        catch (TTransportException)
        {
          throw;
        }
        catch (Exception tmp1298)
        {
          var tmp1299 = $"Error occurred in {GetType().FullName}: {tmp1298.Message}";
          if(_logger != null)
            _logger.LogError(tmp1298, tmp1299);
          else
            Console.Error.WriteLine(tmp1299);
          var tmp1300 = new TApplicationException(TApplicationException.ExceptionType.InternalError," Internal error.");
          await oprot.WriteMessageBeginAsync(new TMessage("chainUpdateEdge", TMessageType.Exception, seqid), cancellationToken);
          await tmp1300.WriteAsync(oprot, cancellationToken);
        }
        await oprot.WriteMessageEndAsync(cancellationToken);
        await oprot.Transport.FlushAsync(cancellationToken);
      }

    }

    public class InternalStructs
    {

      public partial class chainAddEdges_args : TBase
      {
        private global::Nebula.Storage.ChainAddEdgesRequest _req;

        public global::Nebula.Storage.ChainAddEdgesRequest Req
        {
          get
          {
            return _req;
          }
          set
          {
            __isset.req = true;
            this._req = value;
          }
        }


        public Isset __isset;
        public struct Isset
        {
          public bool req;
        }

        public chainAddEdges_args()
        {
        }

        public chainAddEdges_args DeepCopy()
        {
          var tmp1301 = new chainAddEdges_args();
          if((Req != null) && __isset.req)
          {
            tmp1301.Req = (global::Nebula.Storage.ChainAddEdgesRequest)this.Req.DeepCopy();
          }
          tmp1301.__isset.req = this.__isset.req;
          return tmp1301;
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
                  if (field.Type == TType.Struct)
                  {
                    Req = new global::Nebula.Storage.ChainAddEdgesRequest();
                    await Req.ReadAsync(iprot, cancellationToken);
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
            var tmp1302 = new TStruct("chainAddEdges_args");
            await oprot.WriteStructBeginAsync(tmp1302, cancellationToken);
            var tmp1303 = new TField();
            if((Req != null) && __isset.req)
            {
              tmp1303.Name = "req";
              tmp1303.Type = TType.Struct;
              tmp1303.ID = 1;
              await oprot.WriteFieldBeginAsync(tmp1303, cancellationToken);
              await Req.WriteAsync(oprot, cancellationToken);
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
          if (!(that is chainAddEdges_args other)) return false;
          if (ReferenceEquals(this, other)) return true;
          return ((__isset.req == other.__isset.req) && ((!__isset.req) || (System.Object.Equals(Req, other.Req))));
        }

        public override int GetHashCode() {
          int hashcode = 157;
          unchecked {
            if((Req != null) && __isset.req)
            {
              hashcode = (hashcode * 397) + Req.GetHashCode();
            }
          }
          return hashcode;
        }

        public override string ToString()
        {
          var tmp1304 = new StringBuilder("chainAddEdges_args(");
          int tmp1305 = 0;
          if((Req != null) && __isset.req)
          {
            if(0 < tmp1305++) { tmp1304.Append(", "); }
            tmp1304.Append("Req: ");
            Req.ToString(tmp1304);
          }
          tmp1304.Append(')');
          return tmp1304.ToString();
        }
      }


      public partial class chainAddEdges_result : TBase
      {
        private global::Nebula.Storage.ExecResponse _success;

        public global::Nebula.Storage.ExecResponse Success
        {
          get
          {
            return _success;
          }
          set
          {
            __isset.success = true;
            this._success = value;
          }
        }


        public Isset __isset;
        public struct Isset
        {
          public bool success;
        }

        public chainAddEdges_result()
        {
        }

        public chainAddEdges_result DeepCopy()
        {
          var tmp1306 = new chainAddEdges_result();
          if((Success != null) && __isset.success)
          {
            tmp1306.Success = (global::Nebula.Storage.ExecResponse)this.Success.DeepCopy();
          }
          tmp1306.__isset.success = this.__isset.success;
          return tmp1306;
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
                case 0:
                  if (field.Type == TType.Struct)
                  {
                    Success = new global::Nebula.Storage.ExecResponse();
                    await Success.ReadAsync(iprot, cancellationToken);
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
            var tmp1307 = new TStruct("chainAddEdges_result");
            await oprot.WriteStructBeginAsync(tmp1307, cancellationToken);
            var tmp1308 = new TField();

            if(this.__isset.success)
            {
              if (Success != null)
              {
                tmp1308.Name = "Success";
                tmp1308.Type = TType.Struct;
                tmp1308.ID = 0;
                await oprot.WriteFieldBeginAsync(tmp1308, cancellationToken);
                await Success.WriteAsync(oprot, cancellationToken);
                await oprot.WriteFieldEndAsync(cancellationToken);
              }
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
          if (!(that is chainAddEdges_result other)) return false;
          if (ReferenceEquals(this, other)) return true;
          return ((__isset.success == other.__isset.success) && ((!__isset.success) || (System.Object.Equals(Success, other.Success))));
        }

        public override int GetHashCode() {
          int hashcode = 157;
          unchecked {
            if((Success != null) && __isset.success)
            {
              hashcode = (hashcode * 397) + Success.GetHashCode();
            }
          }
          return hashcode;
        }

        public override string ToString()
        {
          var tmp1309 = new StringBuilder("chainAddEdges_result(");
          int tmp1310 = 0;
          if((Success != null) && __isset.success)
          {
            if(0 < tmp1310++) { tmp1309.Append(", "); }
            tmp1309.Append("Success: ");
            Success.ToString(tmp1309);
          }
          tmp1309.Append(')');
          return tmp1309.ToString();
        }
      }


      public partial class chainUpdateEdge_args : TBase
      {
        private global::Nebula.Storage.ChainUpdateEdgeRequest _req;

        public global::Nebula.Storage.ChainUpdateEdgeRequest Req
        {
          get
          {
            return _req;
          }
          set
          {
            __isset.req = true;
            this._req = value;
          }
        }


        public Isset __isset;
        public struct Isset
        {
          public bool req;
        }

        public chainUpdateEdge_args()
        {
        }

        public chainUpdateEdge_args DeepCopy()
        {
          var tmp1311 = new chainUpdateEdge_args();
          if((Req != null) && __isset.req)
          {
            tmp1311.Req = (global::Nebula.Storage.ChainUpdateEdgeRequest)this.Req.DeepCopy();
          }
          tmp1311.__isset.req = this.__isset.req;
          return tmp1311;
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
                  if (field.Type == TType.Struct)
                  {
                    Req = new global::Nebula.Storage.ChainUpdateEdgeRequest();
                    await Req.ReadAsync(iprot, cancellationToken);
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
            var tmp1312 = new TStruct("chainUpdateEdge_args");
            await oprot.WriteStructBeginAsync(tmp1312, cancellationToken);
            var tmp1313 = new TField();
            if((Req != null) && __isset.req)
            {
              tmp1313.Name = "req";
              tmp1313.Type = TType.Struct;
              tmp1313.ID = 1;
              await oprot.WriteFieldBeginAsync(tmp1313, cancellationToken);
              await Req.WriteAsync(oprot, cancellationToken);
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
          if (!(that is chainUpdateEdge_args other)) return false;
          if (ReferenceEquals(this, other)) return true;
          return ((__isset.req == other.__isset.req) && ((!__isset.req) || (System.Object.Equals(Req, other.Req))));
        }

        public override int GetHashCode() {
          int hashcode = 157;
          unchecked {
            if((Req != null) && __isset.req)
            {
              hashcode = (hashcode * 397) + Req.GetHashCode();
            }
          }
          return hashcode;
        }

        public override string ToString()
        {
          var tmp1314 = new StringBuilder("chainUpdateEdge_args(");
          int tmp1315 = 0;
          if((Req != null) && __isset.req)
          {
            if(0 < tmp1315++) { tmp1314.Append(", "); }
            tmp1314.Append("Req: ");
            Req.ToString(tmp1314);
          }
          tmp1314.Append(')');
          return tmp1314.ToString();
        }
      }


      public partial class chainUpdateEdge_result : TBase
      {
        private global::Nebula.Storage.UpdateResponse _success;

        public global::Nebula.Storage.UpdateResponse Success
        {
          get
          {
            return _success;
          }
          set
          {
            __isset.success = true;
            this._success = value;
          }
        }


        public Isset __isset;
        public struct Isset
        {
          public bool success;
        }

        public chainUpdateEdge_result()
        {
        }

        public chainUpdateEdge_result DeepCopy()
        {
          var tmp1316 = new chainUpdateEdge_result();
          if((Success != null) && __isset.success)
          {
            tmp1316.Success = (global::Nebula.Storage.UpdateResponse)this.Success.DeepCopy();
          }
          tmp1316.__isset.success = this.__isset.success;
          return tmp1316;
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
                case 0:
                  if (field.Type == TType.Struct)
                  {
                    Success = new global::Nebula.Storage.UpdateResponse();
                    await Success.ReadAsync(iprot, cancellationToken);
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
            var tmp1317 = new TStruct("chainUpdateEdge_result");
            await oprot.WriteStructBeginAsync(tmp1317, cancellationToken);
            var tmp1318 = new TField();

            if(this.__isset.success)
            {
              if (Success != null)
              {
                tmp1318.Name = "Success";
                tmp1318.Type = TType.Struct;
                tmp1318.ID = 0;
                await oprot.WriteFieldBeginAsync(tmp1318, cancellationToken);
                await Success.WriteAsync(oprot, cancellationToken);
                await oprot.WriteFieldEndAsync(cancellationToken);
              }
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
          if (!(that is chainUpdateEdge_result other)) return false;
          if (ReferenceEquals(this, other)) return true;
          return ((__isset.success == other.__isset.success) && ((!__isset.success) || (System.Object.Equals(Success, other.Success))));
        }

        public override int GetHashCode() {
          int hashcode = 157;
          unchecked {
            if((Success != null) && __isset.success)
            {
              hashcode = (hashcode * 397) + Success.GetHashCode();
            }
          }
          return hashcode;
        }

        public override string ToString()
        {
          var tmp1319 = new StringBuilder("chainUpdateEdge_result(");
          int tmp1320 = 0;
          if((Success != null) && __isset.success)
          {
            if(0 < tmp1320++) { tmp1319.Append(", "); }
            tmp1319.Append("Success: ");
            Success.ToString(tmp1319);
          }
          tmp1319.Append(')');
          return tmp1319.ToString();
        }
      }

    }

  }
}
