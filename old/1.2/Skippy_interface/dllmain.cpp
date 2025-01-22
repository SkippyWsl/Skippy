
#include <cstdint>
#include "Sony/CameraRemote_SDK.h"
#include "Sony/CameraDevice.h"
#include <cstdlib>
#include <filesystem>
#include <iomanip>
#pragma comment(lib, "Cr_Core.lib")
#include <iostream>
#include <string>

#define Skippy_interface_API __declspec(dllexport)

namespace Sony = SCRSDK;
typedef std::shared_ptr<cli::CameraDevice> CameraDevicePtr;
typedef std::vector<CameraDevicePtr> CameraDeviceList;
CameraDeviceList cameraList; // all
CameraDevicePtr camera;

extern "C" Skippy_interface_API int initialize();
extern "C" Skippy_interface_API int setcam();
extern "C" Skippy_interface_API int unloadSDK();
extern "C" Skippy_interface_API bool focus(int seconds);
extern "C" Skippy_interface_API bool picture();
extern "C" Skippy_interface_API bool newpath(CrChar * path, CrChar * prefix, CrInt32 no);
extern "C" Skippy_interface_API long long int* preview();
extern "C" Skippy_interface_API bool bufferunlock();
extern "C" Skippy_interface_API int buffersize();

Skippy_interface_API int initialize()
{
    auto init_success = Sony::Init();
    if (!init_success) {
        Sony::Release();
        return 1;
    }
    Sony::ICrEnumCameraObjectInfo* camera_list = nullptr;
    auto enum_status = Sony::EnumCameraObjects(&camera_list);
    if (CR_FAILED(enum_status) || camera_list == nullptr) {
        Sony::Release();
        return 1;
    }
    auto ncams = camera_list->GetCount();
    std::int32_t cameraNumUniq = 1;
    std::int32_t selectCamera = 1;
    auto* camera_info = camera_list->GetCameraObjectInfo(0);;
    camera = CameraDevicePtr(new cli::CameraDevice(cameraNumUniq, nullptr, camera_info));
    cameraList.push_back(camera);
    camera_list->Release();
    auto connect_status = camera->connect();
    if (!connect_status) {
        Sony::Release();
        return 1;
    }
    return 0;
}
Skippy_interface_API int setcam() {
    return 0;
}

Skippy_interface_API int unloadSDK()
{
    if (camera->is_connected()) {
        auto disconnect_status = camera->disconnect();
        if (!disconnect_status) {
            // try again
            disconnect_status = camera->disconnect();
        }
        if (!disconnect_status)
            return 1;
    }
    camera->release();
    Sony::Release();
    return 0;
}
Skippy_interface_API bool focus(int seconds)
{
    camera->s1_shooting(seconds);
    return true;
}
Skippy_interface_API bool picture()
{
    //camera->af_shutter();
    return camera->af_shutter();
}
Skippy_interface_API bool newpath(CrChar* path, CrChar* prefix, CrInt32 no)
{
    camera->set_path(path, prefix, no);
    return true;
}
Skippy_interface_API bool bufferunlock()
{
    return camera->bufferunlock();
}

Skippy_interface_API long long int* preview()
{
    return camera->preview();  
}

Skippy_interface_API int buffersize()
{
    return camera->buffersize();
}