import React from 'react';
import TextField from '@material-ui/core/TextField';
import Button from '@material-ui/core/Button';
import { Dispatch } from 'redux';
import { shallowEqual, useDispatch, useSelector } from 'react-redux';
import { addPost } from '../../store/action-creators';

type Props = {
    savePost: (post: IPost | any) => void;
}

const AddPost: React.FC<Props> = ({ savePost }) => {
    const [post, setPost] = React.useState<IPost | {}>();
    const handlePostData = (e: React.FormEvent<HTMLTextAreaElement | HTMLInputElement>) => {
        setPost({
            ...post,
            [e.currentTarget.id]: e.currentTarget.value
        });
    }
    const addNewPost = (e: React.FormEvent) => {
        e.preventDefault();
        savePost(post);
    }
    return <form onSubmit={addNewPost}>
        <TextField id="post-message" label="Message" onChange={handlePostData} />
        <Button type="submit" variant="contained" color="primary" disabled={post === undefined ? true : false}>
            Submit
    </Button>
    </form>
};

const Post1337: React.FC = () => {
    const dispatch: Dispatch<any> = useDispatch();
    const savePost = React.useCallback(
        (post: IPost) => dispatch(addPost(post)),
        [dispatch]
    )

    return <div>
        This is where you post 1337
        <AddPost savePost={savePost} />
    </div>
};

export default Post1337;