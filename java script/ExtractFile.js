function extractFile(path){
    path = path.split('.');
    let extension = path.pop();
    path = path.join('.');
    path = path.split('\\');
    let fileName = path.pop();
    console.log(`File name: ${fileName}`);
    console.log(`File extension: ${extension}`)
}
extractFile('C:\\Internal\\training-internal\\Template.pptx')