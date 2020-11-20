using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace GreeterServer
{

  public class GrpcDefinitions
  {

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_init")]
    [NativeCallable(EntryPoint = "grpcsharp_init")]
    static void grpcsharp_init() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_shutdown")]
    [NativeCallable(EntryPoint = "grpcsharp_shutdown")]
    static void grpcsharp_shutdown() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_version_string")]
    [NativeCallableAttribute(EntryPoint = "grpcsharp_version_string")]
    static void grpcsharp_version_string() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_batch_context_create")]
    [NativeCallableAttribute(EntryPoint = "grpcsharp_batch_context_create")]
    static void grpcsharp_batch_context_create() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_request_call_context_destroy")]
    [NativeCallableAttribute(EntryPoint = "grpcsharp_request_call_context_destroy")]
    static void grpcsharp_request_call_context_destroy() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_composite_call_credentials_create")]
    [NativeCallableAttribute(EntryPoint = "grpcsharp_composite_call_credentials_create")]
    static void grpcsharp_composite_call_credentials_create() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_batch_context_recv_initial_metadata")]
    [NativeCallableAttribute(EntryPoint = "grpcsharp_batch_context_recv_initial_metadata")]
    static void grpcsharp_batch_context_recv_initial_metadata() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_batch_context_recv_message_length")]
    [NativeCallableAttribute(EntryPoint = "grpcsharp_batch_context_recv_message_length")]
    static void grpcsharp_batch_context_recv_message_length() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_batch_context_recv_message_next_slice_peek")]
    [NativeCallableAttribute(EntryPoint = "grpcsharp_batch_context_recv_message_next_slice_peek")]
    static void grpcsharp_batch_context_recv_message_next_slice_peek() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_call_credentials_release")]
    [NativeCallable(EntryPoint = "grpcsharp_call_credentials_release")]
    static void grpcsharp_call_credentials_release() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_call_cancel")]
    [NativeCallable(EntryPoint = "grpcsharp_call_cancel")]
    static void grpcsharp_call_cancel() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_call_start_unary")]
    [NativeCallable(EntryPoint = "grpcsharp_call_start_unary")]
    static void grpcsharp_call_start_unary() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_call_cancel_with_status")]
    [NativeCallable(EntryPoint = "grpcsharp_call_cancel_with_status")]
    static void grpcsharp_call_cancel_with_status() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_call_start_server_streaming")]
    [NativeCallable(EntryPoint = "grpcsharp_call_start_server_streaming")]
    static void grpcsharp_call_start_server_streaming() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_call_start_client_streaming")]
    [NativeCallable(EntryPoint = "grpcsharp_call_start_client_streaming")]
    static void grpcsharp_call_start_client_streaming() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_call_start_duplex_streaming")]
    [NativeCallable(EntryPoint = "grpcsharp_call_start_duplex_streaming")]
    static void grpcsharp_call_start_duplex_streaming() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_call_send_close_from_client")]
    [NativeCallable(EntryPoint = "grpcsharp_call_send_close_from_client")]
    static void grpcsharp_call_send_close_from_client() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_call_send_message")]
    [NativeCallable(EntryPoint = "grpcsharp_call_send_message")]
    static void grpcsharp_call_send_message() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_batch_context_recv_status_on_client_status")]
    [NativeCallable(EntryPoint = "grpcsharp_batch_context_recv_status_on_client_status")]
    static void grpcsharp_batch_context_recv_status_on_client_status() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_batch_context_recv_status_on_client_details")]
    [NativeCallable(EntryPoint = "grpcsharp_batch_context_recv_status_on_client_details")]
    static void grpcsharp_batch_context_recv_status_on_client_details() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_batch_context_recv_status_on_client_trailing_metadata")]
    [NativeCallable(EntryPoint = "grpcsharp_batch_context_recv_status_on_client_trailing_metadata")]
    static void grpcsharp_batch_context_recv_status_on_client_trailing_metadata() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_batch_context_recv_close_on_server_cancelled")]
    [NativeCallable(EntryPoint = "grpcsharp_batch_context_recv_close_on_server_cancelled")]
    static void grpcsharp_batch_context_recv_close_on_server_cancelled() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_batch_context_reset")]
    [NativeCallable(EntryPoint = "grpcsharp_batch_context_reset")]
    static void grpcsharp_batch_context_reset() { }


    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_batch_context_destroy")]
    [NativeCallable(EntryPoint = "grpcsharp_batch_context_destroy")]
    static void grpcsharp_batch_context_destroy() { }


    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_request_call_context_create")]
    [NativeCallable(EntryPoint = "grpcsharp_request_call_context_create")]
    static void grpcsharp_request_call_context_create() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_request_call_context_call")]
    [NativeCallable(EntryPoint = "grpcsharp_request_call_context_call")]
    static void grpcsharp_request_call_context_call() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_request_call_context_method")]
    [NativeCallable(EntryPoint = "grpcsharp_request_call_context_method")]
    static void grpcsharp_request_call_context_method() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_request_call_context_host")]
    [NativeCallable(EntryPoint = "grpcsharp_request_call_context_host")]
    static void grpcsharp_request_call_context_host() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_request_call_context_deadline")]
    [NativeCallable(EntryPoint = "grpcsharp_request_call_context_deadline")]
    static void grpcsharp_request_call_context_deadline() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_request_call_context_request_metadata")]
    [NativeCallable(EntryPoint = "grpcsharp_request_call_context_request_metadata")]
    static void grpcsharp_request_call_context_request_metadata() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_request_call_context_reset")]
    [NativeCallable(EntryPoint = "grpcsharp_request_call_context_reset")]
    static void grpcsharp_request_call_context_reset() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_request_call_context_destroypublic")]
    [NativeCallable(EntryPoint = "grpcsharp_request_call_context_destroypublic")]
    static void grpcsharp_request_call_context_destroypublic() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_composite_call_credentials_createpublic")]
    [NativeCallable(EntryPoint = "grpcsharp_composite_call_credentials_createpublic")]
    static void grpcsharp_composite_call_credentials_createpublic() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_call_credentials_releasepublic")]
    [NativeCallable(EntryPoint = "grpcsharp_call_credentials_releasepublic")]
    static void grpcsharp_call_credentials_releasepublic() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_call_cancelpublic")]
    [NativeCallable(EntryPoint = "grpcsharp_call_cancelpublic")]
    static void grpcsharp_call_cancelpublic() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_call_cancel_with_statuspublic")]
    [NativeCallable(EntryPoint = "grpcsharp_call_cancel_with_statuspublic")]
    static void grpcsharp_call_cancel_with_statuspublic() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_call_start_unarypublic")]
    [NativeCallable(EntryPoint = "grpcsharp_call_start_unarypublic")]
    static void grpcsharp_call_start_unarypublic() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_call_start_client_streamingpublic")]
    [NativeCallable(EntryPoint = "grpcsharp_call_start_client_streamingpublic")]
    static void grpcsharp_call_start_client_streamingpublic() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_call_send_messagepublic")]
    [NativeCallable(EntryPoint = "grpcsharp_call_send_messagepublic")]
    static void grpcsharp_call_send_messagepublic() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_call_send_close_from_clientpublic")]
    [NativeCallable(EntryPoint = "grpcsharp_call_send_close_from_clientpublic")]
    static void grpcsharp_call_send_close_from_clientpublic() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_call_send_status_from_server")]
    [NativeCallable(EntryPoint = "grpcsharp_call_send_status_from_server")]
    static void grpcsharp_call_send_status_from_server() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_call_recv_message")]
    [NativeCallable(EntryPoint = "grpcsharp_call_recv_message")]
    static void grpcsharp_call_recv_message() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_call_recv_initial_metadata")]
    [NativeCallable(EntryPoint = "grpcsharp_call_recv_initial_metadata")]
    static void grpcsharp_call_recv_initial_metadata() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_call_start_serverside")]
    [NativeCallable(EntryPoint = "grpcsharp_call_start_serverside")]
    static void grpcsharp_call_start_serverside() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_call_send_initial_metadata")]
    [NativeCallable(EntryPoint = "grpcsharp_call_send_initial_metadata")]
    static void grpcsharp_call_send_initial_metadata() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_call_set_credentials")]
    [NativeCallable(EntryPoint = "grpcsharp_call_set_credentials")]
    static void grpcsharp_call_set_credentials() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_call_get_peer")]
    [NativeCallable(EntryPoint = "grpcsharp_call_get_peer")]
    static void grpcsharp_call_get_peer() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_call_destroy")]
    [NativeCallable(EntryPoint = "grpcsharp_call_destroy")]
    static void grpcsharp_call_destroy() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_channel_args_create")]
    [NativeCallable(EntryPoint = "grpcsharp_channel_args_create")]
    static void grpcsharp_channel_args_create() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_channel_args_set_string")]
    [NativeCallable(EntryPoint = "grpcsharp_channel_args_set_string")]
    static void grpcsharp_channel_args_set_string() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_channel_args_set_integer")]
    [NativeCallable(EntryPoint = "grpcsharp_channel_args_set_integer")]
    static void grpcsharp_channel_args_set_integer() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_channel_args_destroy")]
    [NativeCallable(EntryPoint = "grpcsharp_channel_args_destroy")]
    static void grpcsharp_channel_args_destroy() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_override_default_ssl_roots")]
    [NativeCallable(EntryPoint = "grpcsharp_override_default_ssl_roots")]
    static void grpcsharp_override_default_ssl_roots() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_ssl_credentials_create")]
    [NativeCallable(EntryPoint = "grpcsharp_ssl_credentials_create")]
    static void grpcsharp_ssl_credentials_create() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_composite_channel_credentials_create")]
    [NativeCallable(EntryPoint = "grpcsharp_composite_channel_credentials_create")]
    static void grpcsharp_composite_channel_credentials_create() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_channel_credentials_release")]
    [NativeCallable(EntryPoint = "grpcsharp_channel_credentials_release")]
    static void grpcsharp_channel_credentials_release() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_insecure_channel_create")]
    [NativeCallable(EntryPoint = "grpcsharp_insecure_channel_create")]
    static void grpcsharp_insecure_channel_create() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_secure_channel_create")]
    [NativeCallable(EntryPoint = "grpcsharp_secure_channel_create")]
    static void grpcsharp_secure_channel_create() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_channel_create_call")]
    [NativeCallable(EntryPoint = "grpcsharp_channel_create_call")]
    static void grpcsharp_channel_create_call() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_channel_check_connectivity_state")]
    [NativeCallable(EntryPoint = "grpcsharp_channel_check_connectivity_state")]
    static void grpcsharp_channel_check_connectivity_state() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_channel_watch_connectivity_state")]
    [NativeCallable(EntryPoint = "grpcsharp_channel_watch_connectivity_state")]
    static void grpcsharp_channel_watch_connectivity_state() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_channel_get_target")]
    [NativeCallable(EntryPoint = "grpcsharp_channel_get_target")]
    static void grpcsharp_channel_get_target() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_channel_destroy")]
    [NativeCallable(EntryPoint = "grpcsharp_channel_destroy")]
    static void grpcsharp_channel_destroy() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_sizeof_grpc_event")]
    [NativeCallable(EntryPoint = "grpcsharp_sizeof_grpc_event")]
    static void grpcsharp_sizeof_grpc_event() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_completion_queue_create_async")]
    [NativeCallable(EntryPoint = "grpcsharp_completion_queue_create_async")]
    static void grpcsharp_completion_queue_create_async() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_completion_queue_create_sync")]
    [NativeCallable(EntryPoint = "grpcsharp_completion_queue_create_sync")]
    static void grpcsharp_completion_queue_create_sync() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_completion_queue_shutdown")]
    [NativeCallable(EntryPoint = "grpcsharp_completion_queue_shutdown")]
    static void grpcsharp_completion_queue_shutdown() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_completion_queue_next")]
    [NativeCallable(EntryPoint = "grpcsharp_completion_queue_next")]
    static void grpcsharp_completion_queue_next() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_completion_queue_pluck")]
    [NativeCallable(EntryPoint = "grpcsharp_completion_queue_pluck")]
    static void grpcsharp_completion_queue_pluck() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_completion_queue_destroy")]
    [NativeCallable(EntryPoint = "grpcsharp_completion_queue_destroy")]
    static void grpcsharp_completion_queue_destroy() { }

    [UnmanagedCallersOnly(EntryPoint = "gprsharp_free")]
    [NativeCallable(EntryPoint = "gprsharp_free")]
    static void gprsharp_free() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_metadata_array_create")]
    [NativeCallable(EntryPoint = "grpcsharp_metadata_array_create")]
    static void grpcsharp_metadata_array_create() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_metadata_array_add")]
    [NativeCallable(EntryPoint = "grpcsharp_metadata_array_add")]
    static void grpcsharp_metadata_array_add() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_metadata_array_count")]
    [NativeCallable(EntryPoint = "grpcsharp_metadata_array_count")]
    static void grpcsharp_metadata_array_count() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_metadata_array_get_key")]
    [NativeCallable(EntryPoint = "grpcsharp_metadata_array_get_key")]
    static void grpcsharp_metadata_array_get_key() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_metadata_array_get_value")]
    [NativeCallable(EntryPoint = "grpcsharp_metadata_array_get_value")]
    static void grpcsharp_metadata_array_get_value() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_metadata_array_destroy_full")]
    [NativeCallable(EntryPoint = "grpcsharp_metadata_array_destroy_full")]
    static void grpcsharp_metadata_array_destroy_full() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_redirect_log")]
    [NativeCallable(EntryPoint = "grpcsharp_redirect_log")]
    static void grpcsharp_redirect_log() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_native_callback_dispatcher_init")]
    [NativeCallable(EntryPoint = "grpcsharp_native_callback_dispatcher_init")]
    static void grpcsharp_native_callback_dispatcher_init() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_metadata_credentials_create_from_plugin")]
    [NativeCallable(EntryPoint = "grpcsharp_metadata_credentials_create_from_plugin")]
    static void grpcsharp_metadata_credentials_create_from_plugin() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_metadata_credentials_notify_from_plugin")]
    [NativeCallable(EntryPoint = "grpcsharp_metadata_credentials_notify_from_plugin")]
    static void grpcsharp_metadata_credentials_notify_from_plugin() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_ssl_server_credentials_create")]
    [NativeCallable(EntryPoint = "grpcsharp_ssl_server_credentials_create")]
    static void grpcsharp_ssl_server_credentials_create() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_server_credentials_release")]
    [NativeCallable(EntryPoint = "grpcsharp_server_credentials_release")]
    static void grpcsharp_server_credentials_release() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_server_create")]
    [NativeCallable(EntryPoint = "grpcsharp_server_create")]
    static void grpcsharp_server_create() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_server_register_completion_queue")]
    [NativeCallable(EntryPoint = "grpcsharp_server_register_completion_queue")]
    static void grpcsharp_server_register_completion_queue() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_server_add_insecure_http2_port")]
    [NativeCallable(EntryPoint = "grpcsharp_server_add_insecure_http2_port")]
    static void grpcsharp_server_add_insecure_http2_port() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_server_add_secure_http2_port")]
    [NativeCallable(EntryPoint = "grpcsharp_server_add_secure_http2_port")]
    static void grpcsharp_server_add_secure_http2_port() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_server_start")]
    [NativeCallable(EntryPoint = "grpcsharp_server_start")]
    static void grpcsharp_server_start() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_server_request_call")]
    [NativeCallable(EntryPoint = "grpcsharp_server_request_call")]
    static void grpcsharp_server_request_call() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_server_cancel_all_calls")]
    [NativeCallable(EntryPoint = "grpcsharp_server_cancel_all_calls")]
    static void grpcsharp_server_cancel_all_calls() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_server_shutdown_and_notify_callback")]
    [NativeCallable(EntryPoint = "grpcsharp_server_shutdown_and_notify_callback")]
    static void grpcsharp_server_shutdown_and_notify_callback() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_server_destroy")]
    [NativeCallable(EntryPoint = "grpcsharp_server_destroy")]
    static void grpcsharp_server_destroy() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_call_auth_context")]
    [NativeCallable(EntryPoint = "grpcsharp_call_auth_context")]
    static void grpcsharp_call_auth_context() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_auth_context_peer_identity_property_name")]
    [NativeCallable(EntryPoint = "grpcsharp_auth_context_peer_identity_property_name")]
    static void grpcsharp_auth_context_peer_identity_property_name() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_auth_context_property_iterator")]
    [NativeCallable(EntryPoint = "grpcsharp_auth_context_property_iterator")]
    static void grpcsharp_auth_context_property_iterator() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_auth_property_iterator_next")]
    [NativeCallable(EntryPoint = "grpcsharp_auth_property_iterator_next")]
    static void grpcsharp_auth_property_iterator_next() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_auth_context_release")]
    [NativeCallable(EntryPoint = "grpcsharp_auth_context_release")]
    static void grpcsharp_auth_context_release() { }

    [UnmanagedCallersOnly(EntryPoint = "gprsharp_now")]
    [NativeCallable(EntryPoint = "gprsharp_now")]
    static void gprsharp_now() { }

    [UnmanagedCallersOnly(EntryPoint = "gprsharp_inf_future")]
    [NativeCallable(EntryPoint = "gprsharp_inf_future")]
    static void gprsharp_inf_future() { }

    [UnmanagedCallersOnly(EntryPoint = "gprsharp_inf_past")]
    [NativeCallable(EntryPoint = "gprsharp_inf_past")]
    static void gprsharp_inf_past() { }

    [UnmanagedCallersOnly(EntryPoint = "gprsharp_convert_clock_type")]
    [NativeCallable(EntryPoint = "gprsharp_convert_clock_type")]
    static void gprsharp_convert_clock_type() { }

    [UnmanagedCallersOnly(EntryPoint = "gprsharp_sizeof_timespec")]
    [NativeCallable(EntryPoint = "gprsharp_sizeof_timespec")]
    static void gprsharp_sizeof_timespec() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_test_callback")]
    [NativeCallable(EntryPoint = "grpcsharp_test_callback")]
    static void grpcsharp_test_callback() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_test_nop")]
    [NativeCallable(EntryPoint = "grpcsharp_test_nop")]
    static void grpcsharp_test_nop() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_test_override_method")]
    [NativeCallable(EntryPoint = "grpcsharp_test_override_method")]
    static void grpcsharp_test_override_method() { }

    [UnmanagedCallersOnly(EntryPoint = "grpcsharp_test_call_start_unary_echo")]
    [NativeCallable(EntryPoint = "grpcsharp_test_call_start_unary_echo")]
    static void grpcsharp_test_call_start_unary_echo() { }

    [UnmanagedCallersOnly(EntryPoint = "dlopen")]
    [NativeCallable(EntryPoint = "dlopen")]
    static void dlopen() { }

    [UnmanagedCallersOnly(EntryPoint = "dlerror")]
    [NativeCallable(EntryPoint = "dlerror")]
    static void dlerror() { }

    [UnmanagedCallersOnly(EntryPoint = "dlsym")]
    [NativeCallable(EntryPoint = "dlsym")]
    static void dlsym() { }
  }
}
