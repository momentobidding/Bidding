import { Injectable } from '@angular/core';
import { ToastrService } from 'ngx-toastr';

@Injectable()
export class NotificationsService {
  private options = {
    title: '',
    position: 'toast-bottom-right',
    canBeClosed: true
  };

  constructor(private toastr: ToastrService) { }

  /**
   * can be used to show success notification popup
   * */
  success(message: string, title = this.options.title, position = this.options.position, canBeClosed = this.options.canBeClosed): void {
    this.toastr.success(message, title, { positionClass: position, closeButton: canBeClosed });
  }

  /**
   * can be used to show error notification popup
   * */
  error(message: string, title = this.options.title, position = this.options.position, canBeClosed = this.options.canBeClosed): void {
    this.toastr.error(message, title, { positionClass: position, closeButton: canBeClosed });
  }

  /**
   * can be used to show warning notification popup
   * */
  warning(message: string, title = this.options.title, position = this.options.position, canBeClosed = this.options.canBeClosed): void {
    this.toastr.warning(message, title, { positionClass: position, closeButton: canBeClosed });
  }
}
