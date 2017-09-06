import { ToastyService } from 'ng2-toasty';
import { ErrorHandler, Inject } from "@angular/core";

export class AppErrorHandler implements ErrorHandler {
    constructor(@Inject(ToastyService) private ToastyService: ToastyService) {      
    }

    handleError(error: any): void {
      this.ToastyService.error({
        title: 'Error',
        msg: 'An unexpected error happened.',
        theme: 'bootstrap',
        showClose: true,
        timeout: 5000
      })
    }
}